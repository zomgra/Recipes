import { useEffect, useState } from 'react';
import { Route, Router, Routes } from 'react-router-dom'
import './App.css';
import { getAllRecipes, getAllInfoRecipes, getAllIngredients } from './services/recipeServise';
import Front from './ui/Front/Front';
import RecipeInfo from './ui/Recipe/RecipeInfo';
import SearchBar from './ui/Search/SearchBar';

function App() {

  const [recipesInfo, setRecipesInfo] = useState([]);
  const [ingredients, setIngredients] = useState([]);

  useEffect(() => {
    async function getRecipes() {
      await setRecipesInfo(await getAllRecipes());
    }
    async function getIngredients() {
      await setIngredients(await getAllIngredients());
    }
    getIngredients();
    getRecipes();
  }, [])

  return (
    <div className="App">
      <Routes>
        <Route element={<Front/>} path='/'></Route>
        <Route path='/recipe/:id' element={<RecipeInfo/>}></Route>
      </Routes>
    </div>
  );
}

export default App;
