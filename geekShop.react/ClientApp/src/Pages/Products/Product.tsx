import React, { useContext, useEffect, useState } from 'react';
import './style.css';
import { AuthContext } from 'oidc-react';
import { CCard, CCardImage, CCardBody, CCardTitle, CCardText, CButton } from '@coreui/react'

interface IProduct {
  id: string;
  name: string;
  imageURL: string
  categoryName: string
}

const useAuth = () => {
  return useContext(AuthContext);
};

const Product = () => {
  const [products, SetProducts] = useState<IProduct[]>([]);
  const user = useAuth();

  const URLProducts = 'https://localhost:4440/api/v1/product';

  useEffect(() => {
    fetch(URLProducts)
      .then((response) => response.json())
      .then((data) => SetProducts(data));
  }, []);

  return (
    <div>
      <h1>Produtos</h1>
      <div className='products'>
        {products.map(product => (
          <div key={product.name}>
            <CCard style={{ width: '18rem' }}>
              <CCardBody>
                <CCardTitle>{product.name}</CCardTitle>
                <CCardImage orientation="top" src={product.imageURL} />
                <CCardText>
                  {product.categoryName}
                </CCardText>
              </CCardBody>
            </CCard>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Product;
