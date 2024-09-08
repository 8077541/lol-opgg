
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import Search from './Components/Search';



function App() {
  return (
    <Router>
      <div className="App">
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
      
          </ul>
        </nav>

      <Search />

     
      </div>
    </Router>
  );
}

export default App;
