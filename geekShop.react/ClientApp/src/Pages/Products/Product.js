import React, { useEffect, useState } from 'react';
import './style.css';

const Product = () => {

  const [products, SetProducts] = useState([]);

  const url = 'https://jsonplaceholder.typicode.com/posts?_limit=10';
  const URLProducts = 'https://localhost:4440/api/v1/product';
  const URLProductscontroller = 'product';

  useEffect(() => {
    fetch(URLProductscontroller)
      .then(response => response.json())
      .then(data => SetProducts(data))
  },[]);

  return (
    <div>
      <h1>Produtos</h1>
      {
        products.map(product => {
          return(
          <h6 key={product.id}>{product.id}</h6>
          )
        })
      }
    </div>
  );
}

export default Product;