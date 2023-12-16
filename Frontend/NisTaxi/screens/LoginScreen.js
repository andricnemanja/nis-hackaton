import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, ScrollView, Image, Button, Pressable, TextInput } from 'react-native';
import { useContext } from 'react';
import QRCode from 'react-native-qrcode-svg';
import QRCodeStyled from 'react-native-qrcode-styled';
import { AuthContext } from '../context/AuthContext';

export default function LoginScreen({ navigation }) {
  const {user} = useContext(AuthContext);
  return (
    <View style={styles.container}>
      <View style={styles.scrollView}>
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <Text style={styles.loginText}>Prijavi se</Text>
      </View>
    
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'start'}}>
        <Text style={styles.fieldText}>Broj telefona</Text>
        <TextInput style={styles.inputField} placeholder='+3816XXXXXXX'/>
      </View>
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'start', marginTop:10}}>
        <Text style={styles.fieldText}>Broj taksi dozvole</Text>
        <TextInput style={styles.inputField} placeholder='XXXXX'/>
      </View>
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <Pressable style={styles.loginBtn} onPress={() => console.log("Button Pressed")}>
          <Text style={styles.loginBtnText}>Prijavi se</Text>
        </Pressable>
      </View>
        <StatusBar style="auto" />
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    width: '100%',
    height: '100%',
    backgroundColor: '#fff',
    paddingLeft: 20,
    paddingRight: 20,
    alignItems: 'center',
    justifyContent: 'center',
  },
  scrollView:{
    width: '100%',
    height:400,
  },
  root: {
    justifyContent: 'center',
    alignItems: 'center',
  },
  loginText:{
    fontSize: 34,
    fontWeight: '700',
  },
  fieldText:{
    fontSize: 15,
    fontWeight: '400',
    color: '#8F8F8F',
  },
  loginBtn:{
    marginTop: 40,
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 15,
    paddingHorizontal: 32,
    width: '100%',
    borderRadius: 6,
    elevation: 4,
    backgroundColor: '#F5BF24',
  },
  loginBtnText:{
    fontSize: 18,
    fontWeight: '700',
  },
  inputField:{
    height: 60,
    marginTop: 10,
    paddingLeft:10,
    backgroundColor: '#EDEEEC',
    borderRadius: 6,
  }
});
