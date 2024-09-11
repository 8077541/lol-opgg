import React, { useState } from 'react';
import { useNavigate } from "react-router-dom";
import './Search.css';  

const Search = () => {
    const navigate = useNavigate();
    const [gameName, setGameName] = useState('');
    const [tagLine, setTagLine] = useState('');
    const [region, setRegion] = useState('EUW');   

    const handleSearch = () => {
   
        navigate(`/profile/${gameName}/${tagLine}/${region}`);
    };
    const handleRegion = (e) => {
      setRegion(e.currentTarget.value);
      console.log(region);
    }
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
  <select  placeholder='Region' onChange={handleRegion}>
    <option value="EUW" >EUW</option>
    <option value="EUNE">EUNE</option>
    <option value="NA">NA</option>
    <option value="BR">BR</option>
    <option value="JP">JP</option>
    <option value="KR">KR</option>
    <option value="LAN">LAN</option>
    <option value="LAS">LAS</option>
    <option value="OCE">OCE</option>
    <option value="TR">TR</option>
    <option value="RU">RU</option>
    <option value="SG">SG</option>
    <option value="PH">PH</option>
    <option value="TH">TH</option>
    <option value="TW">TN</option>
    <option value="VN">VN</option>
    </select>  
  <button className='button' onClick={handleSearch}>Search</button>
  </div>   
    </div>
    );
};

export default Search;