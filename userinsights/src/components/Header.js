import React from 'react';
import { Link } from 'react-router-dom';
import './Css/Header.css';

const Header = () => (
  
  <header className="header">
    <div className="logo-name">Desenvolvedor Full-Stack<br /> Everton Leão</div>
    <nav>
      <ul className="nav-links">
        <li><Link to="./UserList">Grid de Usuários</Link></li>
        <li><Link to="./SobreProjeto">Sobre Projeto</Link></li>
      </ul>
    </nav>
  </header>
);

export default Header;
