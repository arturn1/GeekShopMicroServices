import React, { useContext } from "react";
import {AuthContext } from 'oidc-react';


const useAuth = () => {
    return useContext(AuthContext);
  }

export default function LogoutBtn() {
  const user = useAuth();


  return <button type="button" className="btn btn-primary" onClick={() => user?.signOut}>Logout</button>
}