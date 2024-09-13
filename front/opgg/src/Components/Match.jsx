import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';

const Match = (props) => {
    const searchParams = useParams();
    const [matchData, setMatchData] = useState('');

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch(`http://localhost:5283/api/match/matchDetails?matchId=${props.match}`);
                const data = await response.json();
                setMatchData(data);
                console.log(props);
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };
    
        fetchData();
    }, [props.match]);

  return (
    <div>{matchData.matchId}</div>
  )
}

export default Match