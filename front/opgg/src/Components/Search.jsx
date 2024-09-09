import React, { useState } from 'react';
import { useNavigate } from "react-router-dom";
import './Search.css';  

const Search = () => {
    const navigate = useNavigate();
    const [gameName, setGameName] = useState('');
    const [tagLine, setTagLine] = useState('');
    const [region, setRegion] = useState('');   

    const handleSearch = () => {
        navigate(`/profile/${gameName}/${tagLine}/${region}`);
    };


    return (
        <div id="center">
          <form id="formSearchTwo" onSubmit={handleSearch}>

        <input
          autocomplete="off"
          id="searchBar"
          type="text"   
  value={gameName}
  onChange={(e) => setGameName(e.target.value)}
          placeholder="Summoner's name"
        />
        <input
          autocomplete="off"
          id="tagBar"
          type="text"
  value={tagLine}
  onChange={(e) => setTagLine(e.target.value)}
          placeholder="Tagline"
        />
        <button id='searchButton' type="submit">Search</button>
      </form>
     
    </div>
    );
};

export default Search;