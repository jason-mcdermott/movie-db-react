import React, { Component } from 'react';
import { Button } from 'react-bootstrap';

export class MovieList extends Component {
    displayName = MovieList.name

  constructor(props) {
    super(props);
    this.state = {
        movies: [],
        loading: true
    };

    this.displayMovie = this.displayMovie.bind(this);
    this.displayDirector = this.displayDirector.bind(this);
    this.goBack = this.goBack.bind(this);
     
    fetch('api/movie/list')
      .then(response => response.json())
      .then(data => {
          this.setState({ movies: data, loading: false });
      });
  }

    displayMovie(e, id) {
        e.preventDefault();
        this.props.history.push(`/movie/${id}`);
    } 

    displayDirector(e, id) {
        e.preventDefault();
        this.props.history.push(`/director/${id}`);
    } 

    goBack() {
        this.props.history.goBack();
    }
    
    static renderMovieTable(self) {
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
              {self.state.movies.map(movie =>
                <tr key={movie.id}>
                    <td><a href="" onClick={(e) => self.displayMovie(e, movie.id)}>{movie.title}</a></td>
                    <td><a href="" onClick={(e) => self.displayDirector(e, movie.director.id)}>{movie.director.name}</a></td>
                    <td>{movie.releaseDate}</td>
                </tr>
              )}
            </tbody>
          </table>
        );
    }

    
    render() {
        var self = this;
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : MovieList.renderMovieTable(self);

        return (
          <div>
            <h1>Movies</h1>
            <p>Welcome to the Movie Database</p>
                {contents}
            <Button className="button" onClick={this.goBack}>Back</Button>
          </div>
        );
    } 
}