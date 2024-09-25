import React, { useEffect, useState } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import './Match.css';

const Match = (props) => {
    const navigate = useNavigate(); 
    const searchParams = useParams();
    const [matchData, setMatchData] = useState('');
    const [summoner, setSummoner] = useState('');
    const [csm, setCsm] = useState(0);
    const [items, setItems] = useState([]);
    const [runes, setRunes] = useState([]);
    const [summonerRunes, setSummonerRunes] = useState([]);



    function assignRunes(runes){
      let array = [];

      for(let i = 0; i < runes.length; i++){
      array.push({
        id: runes[i].id,
        name: runes[i].icon.toLowerCase(),
      });
      for(let j = 0; j < runes[i].slots.length; j++){
        for(let k = 0; k < runes[i].slots[j].runes.length; k++){
          array.push({
            id: runes[i].slots[j].runes[k].id,
            name: runes[i].slots[j].runes[k].icon.toLowerCase(),
          });
        }
      }
      setRunes(array);

    }
    }

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
      let csm = (cs / time).toFixed(1);
      return csm;
    }
    function handleProfileRedirect(gameName, tagLine, region){
      navigate(`/profile/${gameName}/${tagLine}/${region}`);
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
                const runesResponse = await fetch('https://ddragon.leagueoflegends.com/cdn/14.19.1/data/en_US/runesReforged.json');
                const runesData = await runesResponse.json();
                setRunes(runesData);
                setMatchData(data);
                assignRunes(runesData);

                mainSummoner(data.participants, props.gameName);

                
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };
    
        fetchData();
    }, [props.match]);

    function mainSummoner(arr, name){
    
        for(let i = 0; i < arr.length; i++){
          
            if(arr[i].riotIdGameName.toLowerCase() === name.toLowerCase()){
              let items = [];
              items.push(arr[i].item0);
              items.push(arr[i].item1);
              items.push(arr[i].item2);
              items.push(arr[i].item3);
              items.push(arr[i].item4);
              items.push(arr[i].item5);
              items.push(arr[i].item6);
                setItems(items);
                console.log(arr[i])
                setSummoner(arr[i]);
                setMainRunes(runes);

                
                break;
            }
        }
   }    
    function setMainRunes(runes){
      let array =[];
      let userRunes = [summoner.primaryRune0, summoner.primaryRune1, summoner.primaryRune2, summoner.secondaryRune0, summoner.secondaryRune1];
        userRunes.forEach(rune => {
          console.log(runes.find(r => r.id === rune).name);
          array.push(runes.find(r => r.id === rune).name);
          
        });
        setSummonerRunes(array);
    }
        

    
if(!summoner) {
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
          <div className='summonerStats'>
          <h1> {summoner.kills} / {summoner.deaths} / {summoner.assists} </h1>
          <h2>{summoner.totalMinionsKilled}CS ({calcCSM()})</h2>
      
          <h2>Kda: {summoner.kda.toFixed(2)}</h2>
          
   </div>
   <div className='items'>
    {items.map(item => {
 
      if(!item){ return <div className='emptyItem'></div>}else{
      return(
        <img
        className="itemPortrait"
        src={`https://ddragon.leagueoflegends.com/cdn/14.18.1/img/item/${item}.png`}
        alt="Item Portrait"
      />)}
    })}

   </div>
    <div className='runes'>
    {summonerRunes.map(rune => {
      return <img
      className="runePortrait"
      src={`https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/${rune}`}
      alt="Rune Portrait" />})}
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
                <h3 onClick={() => handleProfileRedirect(participant.riotIdGameName, participant.riotIdTagLine, matchData.platformId)}>{participant.riotIdGameName}</h3>
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
                 <h3 onClick={() => handleProfileRedirect(participant.riotIdGameName, participant.riotIdTagLine, matchData.platformId)}>{participant.riotIdGameName}</h3>
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