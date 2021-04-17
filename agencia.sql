-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Abr-2021 às 18:21
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `agencia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacote`
--

CREATE TABLE `pacote` (
  `idpacote` int(11) NOT NULL,
  `NomePacote` varchar(100) NOT NULL,
  `origempacote` varchar(100) NOT NULL,
  `destinopacote` varchar(100) NOT NULL,
  `atrativos` varchar(100) NOT NULL,
  `saida` varchar(50) NOT NULL,
  `retorno` varchar(50) NOT NULL,
  `idUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacote`
--

INSERT INTO `pacote` (`idpacote`, `NomePacote`, `origempacote`, `destinopacote`, `atrativos`, `saida`, `retorno`, `idUser`) VALUES
(4, 'Rio de Janeiro', 'Salvador', 'Rio de Janeiro', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. ', '22/05/2079', '15/08/2900', 1),
(6, 'tsbtrgbv', 'tsbgvstb', 'bhsb', 'rb', 'bhtb', 'bwsht', 2),
(7, 'tsrbgr', 'bvgftb', 'srbhry', 'snh', 'nbh', 'nhj', 9),
(8, 'ssrbvgts', 'vgtr', 'bw', 'btswv', 'tbvgw', 'bvsgwt', 9),
(9, 'gsrtg', 'ehy', 'njtenhjy', 'njhy', 'nhygn', 'njhyenhj', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `iduser` int(11) NOT NULL,
  `nomeuser` varchar(100) NOT NULL,
  `datanasc` varchar(20) NOT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `tipo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`iduser`, `nomeuser`, `datanasc`, `login`, `senha`, `tipo`) VALUES
(5, 'Ellen', '15/09/2000', 'lucas', '225599', 0),
(6, 'Maro', '30/08/8979', 'maro', '112233', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pacote`
--
ALTER TABLE `pacote`
  ADD PRIMARY KEY (`idpacote`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`iduser`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pacote`
--
ALTER TABLE `pacote`
  MODIFY `idpacote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `iduser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
