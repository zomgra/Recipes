import { useEffect, useState } from 'react';
import { Route, Router } from 'react-router-dom'
import './App.css';
import { getAllRecipes, getAllInfoRecipes } from './services/recipeServise';

function App() {

  const [recipesInfo, setRecipesInfo] = useState([]);

  useEffect(() => {
    async function getRecipes() {
      await setRecipesInfo(await getAllInfoRecipes());
    }
    getRecipes();
  }, [])


  return (
    <div className="App">
      <SearchBar />
      <Router>
        <Route element={<Front />} path='/'></Route>
      </Router>
    </div>
  );
}

export default App;
