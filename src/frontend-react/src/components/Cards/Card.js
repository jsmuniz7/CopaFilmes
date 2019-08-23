import React from "react";

import "./Card.css";

class Card extends React.Component {
  state = { isSelected: false };

  onClick = () => {
    if (this.props.onCardSelect(this.props.content)) {
      var isSelected = this.state.isSelected;
      this.setState({ isSelected: !isSelected });
    }
  };

  render() {
    return (
      <div
        onClick={this.onClick}
        className="card teste"
        style={{ cursor: "pointer" }}
      >
        <div className="right floated content">
          <div className="ui checkbox checked">
            <input
              type="checkbox"
              checked={this.state.isSelected}
              onChange={() => {}}
            />
            <label />
          </div>
          <div className="right floated description">
            <h5>{this.props.content.titulo}</h5>
          </div>
          <div className="right floated description">
            {this.props.content.ano}
          </div>
        </div>
      </div>
    );
  }
}

export default Card;
