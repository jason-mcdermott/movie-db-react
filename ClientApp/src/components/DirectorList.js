import React, { Component } from 'react';

export class DirectorList extends Component {
    displayName = DirectorList.name

  constructor(props) {
    super(props);
      this.state = { directors: [], loading: true };

    fetch('api/director/list')
      .then(response => response.json())
      .then(data => {
          this.setState({ directors: data, loading: false });
      });
  }

    static renderDirectorTable(directors) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>Director</th>
            <th>Movies</th>
            <th>Years Active</th>
          </tr>
        </thead>
        <tbody>
          {directors.map(director =>
            <tr key={director.id}>
                <td>{director.name}</td>
                <td></td>
                <td>{director.yearsActive}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : DirectorList.renderDirectorTable(this.state.directors);

    return (
      <div>
        <h1>Directors</h1>
        <p>Welcome to the Movie Database</p>
        {contents}
      </div>
    );
  }
}
