import React, { Component } from 'react';

export class MovieList extends Component {
    displayName = MovieList.name

  constructor(props) {
    super(props);
      this.state = { movies: [], loading: true };

    fetch('api/Movie/list')
      .then(response => response.json())
      .then(data => {
          this.setState({ movies: data, loading: false });
      });
  }

  static renderMovieTable(movies) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>Title</th>
            <th>Director</th>
            <th>Release Date</th>
          </tr>
        </thead>
        <tbody>
          {movies.map(movie =>
            <tr key={movie.id}>
                <td>{movie.title}</td>
                <td>{movie.director.name}</td>
                <td>{movie.releaseDate}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : MovieList.renderMovieTable(this.state.movies);

    return (
      <div>
        <h1>Movies</h1>
        <p>Welcome to the Movie Database</p>
        {contents}
      </div>
    );
  }
}
