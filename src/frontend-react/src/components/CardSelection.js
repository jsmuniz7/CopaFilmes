import React from "react";

import CardList from "./Cards/CardList";
import CardsSelectedCounter from "./CardsSelectedCounter";

class CardSelection extends React.Component {
  state = { cardsSelected: [] };

  onCardSelect = cardSelected => {
    if (!this.state.cardsSelected.find(card => card.id === cardSelected.id)) {
      if (this.state.cardsSelected.length === 8) {
        return false;
      }

      this.setState({
        cardsSelected: [...this.state.cardsSelected, cardSelected]
      });
    } else {
      this.setState({
        cardsSelected: this.state.cardsSelected.filter(
          card => card.id !== cardSelected.id
        )
      });
    }
    return true;
  };
  render() {
    return (
      <div>
        <div className="ui grid">
          <div className="left floated four wide column">
            <CardsSelectedCounter
              selected={this.state.cardsSelected.length}
              total="8"
            />
          </div>
          <div className="right floated three wide column">
            <div className="ui animated button" tabindex="0">
              <div className="visible content">Gerar Campeonato</div>
              <div className="hidden content">
                <i className="right arrow icon" />
              </div>
            </div>
          </div>
        </div>

        <CardList onCardSelect={this.onCardSelect} />
      </div>
    );
  }
}
export default CardSelection;
