import React from 'react';
import Product from './Pages/Products/Product';
import { AuthProvider } from 'oidc-react';
import LogoutBtn from './Pages/Products/components/LogoutBtn';
import '@coreui/coreui/dist/css/coreui.min.css'
import Header from './Pages/Shared/components/Header';

function App() {
  const config = {
    onSignIn: async (user: any) => {
      console.log(JSON.stringify(user, null, 2));
      window.location.hash = '';
    },
    authority: 'https://localhost:4435',
    clientId: 'js',
    redirectUri: 'https://localhost:44483',
    responseType: 'id_token token',
    scope: 'openid profile geek_shopping',
    postLogoutRedirectUri: 'https://localhost:4435',
  };

  return (
    <AuthProvider {...config}>
      <div className='App'>
        <Header />
        <Product></Product>
        <LogoutBtn />
      </div>
    </AuthProvider>
  );
}
export default App;
