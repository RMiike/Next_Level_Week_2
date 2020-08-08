import React from 'react';
import {StatusBar} from 'react-native';
import AppStack from './src/routes/AppStack';

const App = () => {
  return (
    <>
      <StatusBar backgroundColor="#8257E5" barStyle="light-content" />
      <AppStack />
    </>
  );
};

export default App;
