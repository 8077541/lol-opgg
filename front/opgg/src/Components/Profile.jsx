import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import Search from './Search';
import Navbar from './Navbar';

const Profile = () => {

const searchParams = useParams();
const [profileData, setProfileData] = useState('');

useEffect(() => {
    const fetchData = async () => {
        try {
            const response = await fetch(`http://localhost:5283/api/profile?gameName=${searchParams.gameName}&tagLine=${searchParams.tagLine}&region=${searchParams.region}`);
            const data = await response.json();
            setProfileData(data);
            console.log(data);
            // Process the data here
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };

    fetchData();
}, [searchParams.gameName, searchParams.tagLine, searchParams.region]);
if(!profileData) {
return (
        <div>
            <h2>Profile</h2>
            
        </div>
    );
}else{
    return (
        <div>
            <Navbar />
            <div>
            <img
              id="summonerIcon"
              src={`http://ddragon.leagueoflegends.com/cdn/14.17.1/img/profileicon/${profileData.profileIconId}.png`}
              alt="profileIcon"
            ></img>
                <h3>{profileData.gameName} #{profileData.tagLine}</h3>
                <h3>{profileData.soloTier} {profileData.soloRank} {profileData.soloLeaguePoints}LP</h3>
                 
            </div>
        </div>
    );
}
};

export default Profile;