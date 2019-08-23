import React from "react";

import "./Header.css";

const Header = props => {
  return (
    <div className="ui grey inverted segment">
      <div className="content">
        <div className="ui center aligned item">
          <p>CAMPEONATO DE FILMES</p>
        </div>
        <div className="ui grey inverted center aligned item">
          <h1>Fase de Seleção</h1>
        </div>
        <hr />
        <div className="ui grey inverted center aligned item">
          <p>
            Selecione 8 filmes que você deseja que entrem na competição e depois
            pressione o botão gerar meu campeonato para prosseguir
          </p>
        </div>
      </div>
    </div>
  );
};

export default Header;
