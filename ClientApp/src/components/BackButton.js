import React, { Component } from 'react';
import { Button } from 'react-bootstrap';

export class BackButton extends Component {
    
    constructor(props) {
        super(props);
        this.goBack = this.goBack.bind(this);
    }
    
    goBack() {
        this.props.history.goBack();
    }
    
    render() {
        return (
            <div className="back-button">
                <Button className="button" onClick={this.goBack}>Back</Button>
            </div>
        );
    }
}