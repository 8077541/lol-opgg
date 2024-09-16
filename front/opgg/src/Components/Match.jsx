import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import './Match.css';

const Match = (props) => {
    const searchParams = useParams();
    const [matchData, setMatchData] = useState('');
    const [summoner, setSummoner] = useState('');

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch(`http://localhost:5283/api/match/matchDetails?matchId=${props.match}`);
                const data = await response.json();
                setMatchData(data);
                mainSummoner(data.participants, props.gameName);
                console.log(props);
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };
    
        fetchData();
    }, [props.match]);

    function mainSummoner(arr, name){
        console.log(arr);
        for(let i = 0; i < arr.length; i++){
            console.log(arr[i].riotIdGameName.toLowerCase(), name);
            if(arr[i].riotIdGameName.toLowerCase() === name.toLowerCase()){
                setSummoner(arr[i]);
                console.log('SUMMONER SET');
            }
        }
   }    

        

    
if(summoner === ''){
   return <h1>Loading...</h1>
}else{
  return (
    <div className='match' id={summoner.win ? "won" : "lost"}>
      <div className='summoner'>
          <img
            className="mainCharacterPortrait"
            src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-icons/${summoner.championId}.png`}
            alt="Character Portrait"
            title={summoner.championName}
          ></img>
          
          {summoner.kills} / {summoner.deaths} / {summoner.assists} {summoner.totalMinionsKilled}CS
          <img
                    id="keystoneMain"
                    alt="Summoner's keystone rune"
                    src={`http://ddragon.leagueoflegends.com/cdn/img/${summoner.primaryRune0}`}
                    title="Primary Rune"
                  ></img>
          </div>
            <div className='participants'>
              <div className='winners'>
            {matchData.participants.map(participant => {
              if(participant.win){
                return <div className='participant'> <img
                className="characterPortrait"
                src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-icons/${participant.championId}.png`}
                alt="Character Portrait"
                title={participant.championName} />
                <p>{participant.riotIdGameName}</p>
                </div>
              }
          })}
          </div>
          <div className='losers'>
            {matchData.participants.map(participant => {
              if(!participant.win){
                return <div className='participant'><img
                className="characterPortrait"
                src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-icons/${participant.championId}.png`}
                alt="Character Portrait"
                title={participant.championName} />
                <p>{participant.riotIdGameName}</p>
                </div>
              }
          })}
          </div>
            </div>
    </div>
  )
}
}
export default Match