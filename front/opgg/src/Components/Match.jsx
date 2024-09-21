import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import './Match.css';

const Match = (props) => {
    const searchParams = useParams();
    const [matchData, setMatchData] = useState('');
    const [summoner, setSummoner] = useState('');
    const [csm, setCsm] = useState(0);
    const [items, setItems] = useState([]);


    function itemsArray(summoner){
      let items = [];
      items.push(summoner.item0);
      items.push(summoner.item1);
      items.push(summoner.item2);
      items.push(summoner.item3);
      items.push(summoner.item4);
      items.push(summoner.item5);
      items.push(summoner.item6);
      setItems(items);
    }

    function calcCSM(){
      let cs = summoner.totalMinionsKilled;
      let time = matchData.gameDuration / 60;
      let csm = cs / time;
      return csm.toFixed(1);
    }
    function gameMode(id) {
      switch (id) {
        case 400:
          return "Normal Draft";
        case 420:
          return "Ranked Solo/Duo";
        case 430:
          return "Normal Blind";
        case 440:
          return "Ranked Flex";
        case 450:
          return "ARAM";
        case 830:
          return "Intro Bots";
        case 1700:
          return "Arena";
        default:
          return "Unknown gamemode";
      }}
      function gameLength() {
        let sLength = matchData.gameDuration;
        let lengthDec = Math.trunc(sLength / 60);
        return `${lengthDec}m ${sLength - lengthDec * 60}s`;
      }
      function time(timestamp) {
        let tim = new Date().getTime();
        console.log(tim);
        let milago = tim - timestamp;
        let secondsAgo = Math.trunc(milago / 1000);
        let minutesAgo = Math.trunc(secondsAgo / 60);
        
        let hoursAgo = Math.trunc(minutesAgo / 60);
        let daysAgo = Math.trunc(hoursAgo / 24);
        if (daysAgo >= 1) {
          return `${daysAgo} ${daysAgo == 1 ? "Day" : "Days"} ago`;
        }
        if (hoursAgo >= 1) {
          return `${hoursAgo} ${hoursAgo == 1 ? "Hour" : "Hours"} ago`;
        }
        if (minutesAgo >= 1) {
          return `${minutesAgo} ${minutesAgo == 1 ? "Minute" : "Minutes"} ago`;
        }
        return "now";
      }
    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch(`http://localhost:5283/api/match/matchDetails?matchId=${props.match}`);
                const data = await response.json();
                setMatchData(data);
                mainSummoner(data.participants, props.gameName);
                itemsArray(summoner);
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
      <div className='general'>
          <h2>{gameMode(matchData.queueId)}</h2>
        <h3>{time(matchData.gameEndTimeStamp)}</h3>
        <hr></hr>
        <h3>{gameLength()}</h3>
        <h3>{summoner.win ? "Victory" : "Defeat"}</h3>
      </div>
      <div className='summoner'>
      
          <img
            className="mainCharacterPortrait"
            src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/champion-icons/${summoner.championId}.png`}
            alt="Character Portrait"
            title={summoner.championName}
          ></img>
          <div>
          <h1> {summoner.kills} / {summoner.deaths} / {summoner.assists} {summoner.totalMinionsKilled}CS ({calcCSM()})</h1>
          <h2>{summoner.riotIdGameName}</h2>
          <h2>Kda: {summoner.kda.toFixed(2)}</h2>
          
   </div>
   <div className='items'>
    {items.map(item => {
      console.log(item);
      if(item === 0){ return <div></div>}else{
      return(
        <img
        className="itemPortrait"
        src={`https://ddragon.leagueoflegends.com/cdn/14.18.1/img/item/${item}.png`}
        alt="Item Portrait"
      />)}
    })}

   </div>
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
                <h3>{participant.riotIdGameName}</h3>
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
                 <h3>{participant.riotIdGameName}</h3>
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