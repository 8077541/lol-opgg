
import './MatchDetails.css';
import { useNavigate, useParams } from 'react-router-dom';
import React, { useEffect, useState } from 'react';
const MatchDetails = (props) => {
  const navigate = useNavigate();
  const searchParams = useParams();
  const [matchData, setMatchData] = useState('');
  const [summoner, setSummoner] = useState(null);
  function handleProfileRedirect(gameName, tagLine, region){
    setSummoner(null);
    navigate(`/profile/${gameName}/${tagLine}/${region}`);
  }
  useEffect(() => {
    setMatchData(props.matchData);
    setSummoner(props.mainSummoner);
    console.log(summoner, matchData)
  }, [matchData, props.mainSummoner, props.matchData, summoner]);
 
  return (
    <div >
      <table>
            <tr> 
              <th></th>
              <th >Summoner Name</th>
              <th>Riot Tag</th>
              <th>K/DA</th>
            </tr>
      {!summoner ? <div></div> : (
        matchData.participants.map((participant) => {
          return (
          <tr>
            <td><img className='detailedChamp' src={`http://ddragon.leagueoflegends.com/cdn/14.16.1/img/champion/${participant.championName}.png`} alt="champion" /></td>
            <td>{participant.riotIdGameName}</td>
            <td>#{participant.riotIdTagLine}</td>
            <td>{participant.kills}/{participant.deaths}/{participant.assists}</td>
            </tr>
          )
        })
      )}
      </table>
    </div>
  )
}

export default MatchDetails