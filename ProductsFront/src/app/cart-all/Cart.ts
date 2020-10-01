import CartItem from './CartItem';


export default class Cart {
    Id: string;
    SessionId: string;
    ShoppingCartStatus: string;
    cartItems: CartItem[];
}


