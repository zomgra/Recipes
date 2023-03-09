<<<<<<< HEAD
import { useEffect, useState } from 'react';
import { Route, Router } from 'react-router-dom'
import './App.css';
import { getAllRecipes, getAllInfoRecipes, getAllIngredients } from './services/recipeServise';
import SearchBar from './ui/Search/SearchBar';

function App() {

  const [recipesInfo, setRecipesInfo] = useState([]);
  const [ingredients, setIngredients] = useState([])

  useEffect(() => {
    async function getRecipes() {
      await setRecipesInfo(await getAllInfoRecipes());
    }
    async function getIngredietns() {
      await setIngredients(await getAllIngredients());
    }
    getIngredietns()
    getRecipes();
  }, [])


  return (
    <div className="App">
      <SearchBar ingredients={ingredients}/>
      
=======
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
>>>>>>> f136aa0 (added js-client)
    </div>
  );
}

export default App;
