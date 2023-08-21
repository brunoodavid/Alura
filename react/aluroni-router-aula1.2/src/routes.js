import Cardapio from 'pages/Cardapio';
import Inicio from 'pages/Inicio/inicio';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Menu from '../src/components/Menu/menu';
import PaginaPadrao from 'components/PaginaPadrao/paginaPadrao';
import Sobre from 'pages/Sobre/sobre';
import Footer from 'components/Footer/footer';
import NotFound from 'pages/NotFound/NotFound';
import Prato from 'pages/Prato/prato';

export default function AppRouter() {
	return (
		<main className='container'>
			<Router>
				<Menu />
				<Routes>
					<Route path='/' element={<PaginaPadrao />}>
						<Route index element={<Inicio />} />
						<Route path='cardapio' element={<Cardapio />} />
						<Route path='sobre' element={<Sobre />} />
						<Route path='prato/:id' element={<Prato />} />
					</Route>
					<Route path='*' element={<NotFound />} />
				</Routes>
				<Footer />
			</Router>
		</main>
	);
}