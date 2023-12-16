import React, { createContext, useEffect } from "react";
import AsyncStorage from "@react-native-async-storage/async-storage";
import axios from "axios";

export const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [isLoading, setIsLoading] = React.useState(false);
    const [userToken, setUserToken] = React.useState(null);

    const login = (phoneNumber, taxiLicence) => {
        setIsLoading(true);

        // axios.post('http://localhost:8080/login', {
        //     phoneNumber: phoneNumber,
        //     taxiLicence: taxiLicence
        // })
        // .then((response) => {
        //     console.log(response);
        //     setUserToken(response.data.token);
        //     AsyncStorage.setItem('userToken', userToken);
        // })
        // .catch((error) => {
        //     console.log(error);
        // });

        setUserToken('userToken');
        AsyncStorage.setItem('userToken', 'userToken');
        setIsLoading(false);
    }

    const logout = async () => {
        setIsLoading(true);
        setUserToken(null);
        await AsyncStorage.removeItem('userToken');
        setIsLoading(false);
    }

    const getUserToken = async () => {
        try{
            setIsLoading(true);
            let token = await AsyncStorage.getItem('userToken');
            setUserToken(token);
            setIsLoading(false);
        }
        catch(e){
            console.log(e);
        }
    }
    

    useEffect(() => {
        getUserToken();
    }, [])

    return (
        <AuthContext.Provider value={{login, logout, isLoading, userToken}}>
        {children}
        </AuthContext.Provider>
    );
    }