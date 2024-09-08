import React, { useState } from 'react';

const Search = () => {
    const [searchTerm, setSearchTerm] = useState('');
    const [searchTag, setSearchTag] = useState('');
    const [searchResults, setSearchResults] = useState([]);

    const handleSearch = (event) => {
        setSearchTerm(event.target.value);
        // Perform search logic here
    };
    const handleSearchTag = (event) => {
        setSearchTag(event.target.value);
        // Perform search logic here
    };
    const performSearch = () => {
        fetch(`http://localhost:5283/api/profile?gameName=${searchTerm}&tagLine=${searchTag}`, {
            method: 'GET',
           
            headers: {
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
        .then(data => {
            // Handle the response data
            console.log(data);
            setSearchResults(data);
        })
        .catch(error => {
            // Handle any errors
            console.error(error);
        });
    }

    return (
        <div>
            <input
                type="text"
                value={searchTerm}
                onChange={handleSearch}
                placeholder="Search..."
            />
            <input
                type="text"
                value={searchTag}
                onChange={handleSearchTag}
                placeholder="Search..."
            />
            {/* Add additional search-related components or logic here */}
            
             <button onClick={performSearch}>Search</button>
        </div>
       
    );
};

export default Search;