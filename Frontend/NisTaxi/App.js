import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, ScrollView, Image, Button, Pressable } from 'react-native';
import QRCode from 'react-native-qrcode-svg';
import QRCodeStyled from 'react-native-qrcode-styled';

const userIcon = require('./userIcon.png');


export default function App() {
  return (
    <View style={styles.container}>
      <ScrollView   showsVerticalScrollIndicator={false} showsHorizontalScrollIndicator={false}>
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <Image source={userIcon} style={styles.userIcon}></Image>
        <Text style={styles.nameText}>Michigan Michigenovic</Text>
        <Text style={styles.fuelText}>Evro dizel/OPTI dizel</Text>
      </View>
        <QRCodeStyled
          data={'Idemo michigen Idemo michigen'}
          style={styles.svg}
          padding={20}
          pieceSize={8}
          color={'#000'}
          errorCorrectionLevel={'H'}
          innerEyesOptions={{
            borderRadius: 12,
            color: '#000',
          }}
          outerEyesOptions={{
            borderRadius: 12,
            color: '#F5BF24',
          }}
          logo={{
            href: require('./logo.png'),
            padding: 4,
            // scale: 0.8,
            // hidePieces: false,
            // ... any other svg Image props (x, y, preserveAspectRatio, opacity, ...etc)
          }}
        />
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <Text style={styles.nameText}>Preostalo dizela: 600L</Text>
      </View>
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <Pressable style={styles.shareBtn} onPress={() => console.log("Button Pressed")}>
          <Text style={styles.shareBtnText}>Podeli sa prijateljima</Text>
        </Pressable>
      </View>
      <View style={styles.promotionsView}>
        <Text style={styles.nameText}>Promocije</Text>
        <View style={styles.promotion}>

        </View>
      </View>
        <StatusBar style="auto" />
      </ScrollView>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    padding: 0,
    paddingTop: 80,
    alignItems: 'center',
    justifyContent: 'center',
  },
  root: {
    justifyContent: 'center',
    alignItems: 'center',
  },
  svg: {
    marginTop: 20,
    backgroundColor: '#fff',
    borderRadius: 20,
    overflow: 'hidden',
  },
  logoContainer: {
    position: 'absolute',
    width: 88,
    height: 88,
    backgroundColor: '#fff',
    justifyContent: 'center',
    alignItems: 'center',
  },
  logo: {
    width: '90%',
    height: '90%',
    top: -2,
  },
  userIcon:{
    width: 50,
    height: 50,
  },
  nameText:{
    fontSize: 22,
    fontWeight: '700',
    marginTop: 5,
  },
  fuelText:{
    fontSize: 15,
    fontWeight: '400',
    color: '#8F8F8F',
  },
  shareBtn:{
    marginTop: 40,
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 15,
    paddingHorizontal: 32,
    width: '100%',
    borderRadius: 4,
    elevation: 4,
    backgroundColor: '#F5BF24',
  },
  shareBtnText:{
    fontSize: 22,
    fontWeight: '700',
  },
  promotionsView:{
    marginTop: 40,
  },
  promotion:{
    marginTop: 20,
    width: '100%',
    height: 150,
    backgroundColor: '#F5BF24',
    borderRadius: 10,
  }
});
