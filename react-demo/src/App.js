//import logo from "./logo.svg";
import "./App.css";
import Profile from "./components/avatar";
import CoreConcept from "./CoreConcepts";
import reactComponent from "../src/assets/react-components.png";
import { CORE_CONCEPTS } from "./data";
import Counter from "./components/counter";
import InlineStyleExample from "./css/inlineStyle";
import CssClassDemo from "./css/cssClassDemo";
import ServerStatus from "./components/serverstatuswithstatus";
import ProductList from "./components/productlist";


const reactDescriptions = ["Fundamental", "Intermediate", "advanced"];

function getRandomInt(max) {
 return Math.floor(Math.random() * (max + 1));
}

function Header() {
  const description = reactDescriptions[getRandomInt(2)];
  return (
    <header>
      <main>
        <section>
          <ProductList />
          <ServerStatus/>
          {/*<InlineStyleExample/>*/}
          {/*<CssClassDemo/>*/}
            {/*<Counter />*/}
         {/*<h2>Core concepts</h2>
          <ul>
            <CoreConcept
              title={CORE_CONCEPTS[0].title}
              image={CORE_CONCEPTS[0].image}
              description={CORE_CONCEPTS[0].description}
            />
            <CoreConcept
              title={CORE_CONCEPTS[1].title}
              image={CORE_CONCEPTS[1].image}
              description={CORE_CONCEPTS[1].description}
            />
            <CoreConcept {...CORE_CONCEPTS[2]} />
            <CoreConcept {...CORE_CONCEPTS[3]} />
          </ul>*/}
        </section>
      </main>
    </header>
  );
}


function App() {
 return (
   <div className="App">
     <Header />
     <main>Time to start Conditinal Rendering concepts </main>
   </div>
 );
}

export default App;