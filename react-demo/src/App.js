import logo from "./logo.svg";
import "./App.css";
import ItemList from "./itemlist";
import UserList from "./userlist";


function App() {
  const name = "Hexaware";
  const sample = () => {
    console.log("Button clicked");
  };
  return (
    <div className="App">
      <ItemList />
      <UserList />
      {/* <header className="App-header">
        <h2> Hi All welcome {name}</h2>
        <h3> {450 + 500}</h3>
        <h3>{"sample" + 900} </h3>
      </header>

      <button onClick={sample}>click me</button> */}
    </div>
  );
}

export default App;