
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import Search from './Components/Search';
import Navbar from './Components/Navbar';



function App() {
  return (
<>

       <Navbar />

      <Search />
</>
   
  );
}

export default App;
