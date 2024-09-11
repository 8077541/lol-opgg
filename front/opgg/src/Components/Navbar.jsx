
    import './Navbar.css';
    import { useNavigate } from "react-router-dom";

    const Navbar = () => {
        const navigate = useNavigate();
        const handleHome = () => {
            navigate(`/`);
        };
        return (
            <div className="navbar">
                <div className="logo" onClick={handleHome}>OBSERVER</div>
                <div className='credit'>Dominik Janiak</div>
            </div>
        );
    };

    export default Navbar;
