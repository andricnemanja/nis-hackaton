import React, { createContext } from "react";

export const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [isLoading, setIsLoading] = React.useState(false);
    const [userToken, setUserToken] = React.useState(null);

    const login = () => {
        setUserToken('token');
        setIsLoading(false);
    }

    const logout = () => {
        setUserToken(null);
        setIsLoading(false);
    }
    
    return (
        <AuthContext.Provider value={{login, logout, isLoading, userToken}}>
        {children}
        </AuthContext.Provider>
    );
    }