import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import UserList from './components/UserList.js';
import SobreProjeto from './components/SobreProjeto.js'; // Importando a página Sobre
import Header from './components/Header.js';
import Footer from './components/Footer.js';

function App() {
  return (
    <Router>
      <div className="App">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <Header /> {/* Componente do cabeçalho */}
        <Routes>
          <Route path="/SobreProjeto" element={<SobreProjeto />} /> {/* Rota para a página Sobre */}
          <Route path="/UserList" element={<UserList />} /> {/* Rota para a página UserList */}
        </Routes>
        <Footer /> {/* Componente do rodapé */}
      </div>
    </Router>
  );
}

export default App; 
