import React from 'react';
import {View, ImageBackground, Text} from 'react-native';
import giveClassBGImage from '../../assets/images/give-classes-background.png';
import {RectButton} from 'react-native-gesture-handler';

import styles from './styles';
import {useNavigation} from '@react-navigation/native';

const GiveClasses: React.FC = () => {
  const {goBack} = useNavigation();
  function handleNavigateBack() {
    goBack();
  }
  return (
    <View style={styles.container}>
      <ImageBackground
        resizeMode="contain"
        source={giveClassBGImage}
        style={styles.content}>
        <Text style={styles.title}>Quer ser um profy?</Text>
        <Text style={styles.description}>
          Para começar, você precisa se cadastrar como professor na nossa
          plataforma web.{' '}
        </Text>
      </ImageBackground>
      <RectButton style={styles.okButton} onPress={handleNavigateBack}>
        <Text style={styles.okButtonText}>Tudo Bem</Text>
      </RectButton>
    </View>
  );
};

export default GiveClasses;
