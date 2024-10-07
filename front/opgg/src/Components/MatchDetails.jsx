
import './MatchDetails.css';
import { useNavigate, useParams } from 'react-router-dom';
import React, { useEffect, useState } from 'react';
const MatchDetails = (props) => {
  const navigate = useNavigate();
  const searchParams = useParams();
  const [matchData, setMatchData] = useState('');
  const [summoner, setSummoner] = useState(null);
  useEffect(() => {
    setMatchData(props.matchData);
    setSummoner(props.mainSummoner);
    console.log(summoner, matchData)
  }, [matchData, props.mainSummoner, props.matchData, summoner]);
 
  return (
    <div >
      {!summoner ? <div></div> : (
        matchData.participants.map((participant) => {
          return (
            <div>{participant.riotIdGameName} #{participant.riotIdTagLine} - {participant.championName}, {participant.kills} / {participant.deaths} / {participant.assists}</div>

          )
        })
      )}
    </div>
  )
}

export default MatchDetails