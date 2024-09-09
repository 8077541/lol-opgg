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
  <input></input>  
  <input></input>  
  <input></input>  
  <button className='button'>Search</button>
  </div>   
    </div>
    );
};

export default Search;