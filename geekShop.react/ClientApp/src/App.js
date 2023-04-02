import React from 'react';
import Product from './Pages/Products/Product';
import { AuthProvider } from 'oidc-react';

function App() {



    const config = {
        onSignIn: async (user) => {
            alert('You just signed in, congratz! Check out the console!');
            console.log(user);
            window.location.hash = '';
        },
        authority: "https://localhost:4435",
        clientId: "js",
        redirectUri: 'https://localhost:44483',
        responseType: "id_token token",
        scope: "openid profile geek_shopping",
        postLogoutRedirectUri: "https://localhost:4430/signout-callback-oidc",
    };


    return (
        <AuthProvider {...config}>
            <div className="App">
                <header className="App-header">
                    <p>OIDC React</p>
                    <Product></Product>
                </header>
                <button>Clik me</button>
            </div>
        </AuthProvider>
    );
    }
export default App;