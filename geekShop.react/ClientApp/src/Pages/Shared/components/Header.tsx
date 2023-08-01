import React, { useContext } from "react";
import { CNavbar, CContainer, CNavbarBrand, CButton } from '@coreui/react'
import { AuthContext } from 'oidc-react';


const useAuth = () => {
    return useContext(AuthContext);
}

export default function Header() {

    const user = useAuth();

    return (
        <>
            <CNavbar colorScheme="dark" className="bg-dark">
                <CContainer fluid>
                    <CNavbarBrand href="#">
                        Olá, {user?.userData?.profile.name}
                    </CNavbarBrand>
                    <CButton href="https://localhost:4435" >{() => user?.signOut()} Logout</CButton >
                </CContainer>
            </CNavbar>
        </>
    )
}