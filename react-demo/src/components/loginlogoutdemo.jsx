import React,{useState} from "react";

export default function LoginLogoutDemo() {
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const[user,setUser]=useState(null);

    const handleLogin = () => {
        setIsLoggedIn(true);
        setUser({name:"Hexaware"});
        };
        const handleLogout = () => {
            setIsLoggedIn(false);
            setUser(null);
        };
        return(
            <div>
                {isLoggedIn ? (
                    <div>
                        <h1>Logged in as: {user.name}</h1>
                        <button onClick={handleLogout}>Logout</button>
                    </div>
                ) : (
                    <div>
                        <h1>Log In</h1>
                        <button onClick={handleLogin}>Login</button>
                    </div>
                )}
            </div>
        )
}