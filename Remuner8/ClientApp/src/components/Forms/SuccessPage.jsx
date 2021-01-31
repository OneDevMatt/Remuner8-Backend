import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Button } from 'reactstrap';

class SuccessPage extends Component {
  render() {
    return (
      <div className="text-center">
        <h6>Welcome Aboard!</h6>
        <Button color="primary">
          <Link to="/login">PROCEED TO LOGIN</Link>
        </Button>
        <p>🤸‍♂️✨</p>
      </div>
    );
  }
}

export default SuccessPage;
