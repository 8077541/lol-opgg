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
  <div class="loader">
  <div class="head"></div>
  
  <div class="flames">
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
    <div class="particle"></div>
  </div>
  
  <div class="eye"></div>
  </div>
  <div className='searchBox'>
  <input placeholder='Name' onChange={e => setGameName(e.target.value)}></input>  
  <input placeholder='Tag' onChange={e => setTagLine(e.target.value)}></input>  
  <input placeholder='Region'onChange={e => setRegion(e.target.value)}></input>  
  <button className='button' onClick={handleSearch}>Search</button>
  </div>   
    </div>
    );
};

export default Search;