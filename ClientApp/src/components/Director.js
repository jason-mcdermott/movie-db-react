import React, { Component } from 'react';
import { BackButton } from './BackButton';

export class Director extends Component {
  displayName = Director.name

  constructor(props) {
    super(props);
      this.state = {
          director: {},
          loading: true
      };

    var id = this.props.match.params["id"];

    fetch(`api/director/${id}`)
      .then(response => response.json())
      .then(data => {
          this.setState({ director: data, loading: false });
      });
    }
    
    static renderDirectorTable(director) {
        return (
          <table className='table'>
            <thead>
              <tr>
                <th>Director</th>
                <th>Years Active</th>
              </tr>
            </thead>
            <tbody>
                <tr key={director.id}>
                    <td>{director.name}</td>
                    <td>{director.yearsActive}</td>
                </tr>
            </tbody>
          </table>
        );
    }
    
  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : Director.renderDirectorTable(this.state.director);

    return (
      <div>
        <h1>Director</h1>
        <p>Welcome to the Movie Database</p>
            {contents}
        <BackButton history={this.props.history} />
      </div>
    );
  }
}
