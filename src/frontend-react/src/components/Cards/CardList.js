import React from "react";

import Card from "./Card";
import movieList from "../../api/movieList";

class CardList extends React.Component {
  state = { cards: [] };

  componentDidMount() {
    this.fetchMovies();
  }

  async fetchMovies() {
    const response = await movieList.get("/filmes");
    this.setState({ cards: response.data });
  }

  renderCards() {
    return this.state.cards.map(card => (
      <Card
        key={card.id}
        content={card}
        onCardSelect={this.props.onCardSelect}
      />
    ));
  }
  render() {
    return (
      <div className="ui centered aligned cards">{this.renderCards()}</div>
    );
  }
}

export default CardList;
