import { useEffect, useState } from 'react';
import { Route, Router, Routes } from 'react-router-dom'
import './App.css';
import { getAllRecipes, getAllInfoRecipes, getAllIngredients } from './services/recipeServise';
import Front from './ui/Front/Front';
import RecipeInfoPage from './ui/Recipe/RecipeInfoPage';

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
        <Route element={<Front recipes={recipesInfo}/>} path='/'></Route>
        <Route path='/recipe/:id' element={<RecipeInfoPage/>}></Route>
      </Routes>
    </div>
  );
}

export default App;
