import React, { useState } from 'react';
import { useNavigate } from "react-router-dom";

const Search = () => {
    const navigate = useNavigate();
    const [gameName, setGameName] = useState('');
    const [tagLine, setTagLine] = useState('');
    const [region, setRegion] = useState('');   

    const handleSearch = () => {
        navigate(`/profile/${gameName}/${tagLine}/${region}`);
    };

    return (
        <div>
            <input
                type="text"
                placeholder="Summoner Name"
                value={gameName}
                onChange={(e) => setGameName(e.target.value)}
            />
            <input
                type="text"
                placeholder="#Riot Tag"
                value={tagLine}
                onChange={(e) => setTagLine(e.target.value)}
            />
            <input
                type="text"
                placeholder="Region"
                value={region}
                onChange={(e) => setRegion(e.target.value)}
            />
            <button onClick={handleSearch}>Search</button>
        </div>
    );
};

export default Search;