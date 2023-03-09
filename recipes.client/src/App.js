import {Route, Router} from 'react-router-dom'
import './App.css';

function App() {
  return (
    <div className="App">
      <Router>
        <Route element={<Front/>} path='/'></Route>
      </Router>
    </div>
  );
}

export default App;
