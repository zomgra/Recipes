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
      
    </div>
  );
}

export default App;
