import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import Search from './Search';
import Navbar from './Navbar';
import './Profile.css';
import Match from './Match';
const Profile = () => {

const searchParams = useParams();
const [profileData, setProfileData] = useState('');
const [matches, setMatches] = useState('');



	// https://raw.communitydragon.org/14.9/plugins/rcp-fe-lol-static-assets/global/default/images/ranked-emblem/emblem-iron.png
useEffect(() => {
    const fetchData = async () => {
        try {
            const response = await fetch(`http://localhost:5283/api/profile?gameName=${searchParams.gameName}&tagLine=${searchParams.tagLine}&region=${searchParams.region}`);
            const data = await response.json();
            setProfileData(data);
            const responseTwo = await fetch(`http://localhost:5283/api/match?puuid=${data.puuid}`);
            const dataTwo = await responseTwo.json();
            setMatches(dataTwo);
            console.log(data);
            console.log(dataTwo);
            // Process the data here
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };

    fetchData();
}, [searchParams.gameName, searchParams.tagLine, searchParams.region]);

async function updateButton(){
    const requestOptions ={
        method: 'PUT',
        headers: {'Content-Type': 'application/json'},
    }
    console.log('Clicked!   ')
    const response = await fetch(`http://localhost:5283/api/profile?gameName=${searchParams.gameName}&tagLine=${searchParams.tagLine}&region=${searchParams.region}`, requestOptions);
}
if(!profileData) {
return (
     
<div className="loadingspinner center">
  <div id="square1"></div>
  <div id="square2"></div>
  <div id="square3"></div>
  <div id="square4"></div>
  <div id="square5"></div>
</div>
    );
}else{
    return (
        <div className='profilePage'>
            <Navbar />
            <div>
            <div className='profileTab'>
            <img
              className="summonerIcon"
              src={`http://ddragon.leagueoflegends.com/cdn/14.17.1/img/profileicon/${profileData.profileIconId}.png`}
              alt="profileIcon"
            ></img>
                <h3><span className='gameName'>{profileData.gameName}</span> <span className='riotTag'>#{profileData.tagLine}</span></h3>
                <button onClick={updateButton} className='updateButton'>Update</button>
                <h3><span className='rankQueue'>Ranked Solo/Duo</span><br></br> {profileData.soloTier} {profileData.soloRank} {profileData.soloLeaguePoints}LP</h3>
                <img alt='rankEmblem' className='rankedEmblem' src={`https://raw.communitydragon.org/14.9/plugins/rcp-fe-lol-shared-components/global/default/${profileData.soloTier.toLowerCase()}.png`}></img>
                
                <h3><span className='rankQueue'>Ranked Flex</span><br></br> {profileData.flexTier} {profileData.flexRank} {profileData.flexLeaguePoints}LP</h3>
                <img alt='rankEmblem' className='rankedEmblem' src={`https://raw.communitydragon.org/14.9/plugins/rcp-fe-lol-shared-components/global/default/${profileData.flexTier.toLowerCase()}.png`} ></img> 
            </div>
            <div className='matches'>

                <div className='matchList'>
                {matches ? matches.map((match) => {return <><Match key={match} match={match} gameName={searchParams.gameName}></Match></>}) : <div></div>}
                </div>
                
            </div>
            </div>
        </div>
    );
}
};

export default Profile;
