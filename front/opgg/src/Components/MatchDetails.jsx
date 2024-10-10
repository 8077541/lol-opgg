
import './MatchDetails.css';
import { useNavigate, useParams } from 'react-router-dom';
import React, { useEffect, useState } from 'react';
const MatchDetails = (props) => {
  const navigate = useNavigate();
  const searchParams = useParams();
  const [matchData, setMatchData] = useState('');
  const [summoner, setSummoner] = useState(null);
  const [participantItems, setParticipantItems] = useState([]);
  function itemsArray(summoner){
    let items = [];
    items.push(summoner.item0);
    items.push(summoner.item1);
    items.push(summoner.item2);
    items.push(summoner.item3);
    items.push(summoner.item4);
    items.push(summoner.item5);
    items.push(summoner.item6);
    return items;
  }
  function handleProfileRedirect(gameName, tagLine, region){
    setSummoner(null);
    navigate(`/profile/${gameName}/${tagLine}/${region}`);
  }
  useEffect(() => {
    setSummoner(null);
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
              <th>CS</th>
              <th>Items</th>
              <th>Runes</th>
              <th>Damage Dealt</th>
              <th>/ Gold Earned</th>
            </tr>
      {!summoner ? <div></div> : (
        matchData.participants.map((participant) => {
          let items = itemsArray(participant);
          return (
          <tr onClick={() => handleProfileRedirect(participant.riotIdGameName, participant.riotIdTagLine, matchData.platformId)} className='participantRow' id={participant.riotIdGameName == summoner.riotIdGameName ? "mainsum" : ""}>
            <td><img className='detailedChamp' src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-icons/${participant.championId}.png`} alt="champion" /></td>
            <td >{participant.riotIdGameName}</td>
            <td>#{participant.riotIdTagLine}</td>
            <td>{participant.kills}/{participant.deaths}/{participant.assists}</td>
            <td>{participant.totalMinionsKilled} ({(participant.totalMinionsKilled / (matchData.gameDuration / 60)).toFixed(1)})</td>
            <td className='participantItems'>
            {items.map(item => {
            if(!item){ return <div className='emptyParticipantItem'></div>}else{
            return(
              <img
              className="itemParticipant"
              src={`https://ddragon.leagueoflegends.com/cdn/14.18.1/img/item/${item}.png`}
              alt="Item Portrait"
            />)}
            })}
            </td>
            <td className='participantRunes'>
            {participant.runes.map(rune => {
              return <img key={rune.id}
              className="runeParticipant"
              src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/${rune.image.toLowerCase()}`}
              alt="Rune Portrait" />})}
            </td>
            <td>{participant.totalDamageDealtToChampions}</td>
            <td>{participant.goldEarned}</td>
            </tr>
          )
        })
      )}
      </table>
    </div>
  )
}

export default MatchDetails