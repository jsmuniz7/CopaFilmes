import React from "react";

const CardsSelectedCounter = props => {
  return (
    <div className="ui segment">
      Selecionados {props.selected} de {props.total} filmes
    </div>
  );
};

export default CardsSelectedCounter;
