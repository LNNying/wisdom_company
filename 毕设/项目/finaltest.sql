-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 2019-02-17 08:21:45
-- 服务器版本： 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `finaltest`
--

-- --------------------------------------------------------

--
-- 表的结构 `tp_client`
--

CREATE TABLE `tp_client` (
  `id` int(11) NOT NULL,
  `client_name` varchar(40) NOT NULL,
  `phone` varchar(255) DEFAULT NULL,
  `message` varchar(255) DEFAULT NULL,
  `product_id` varchar(255) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `tp_client`
--

INSERT INTO `tp_client` (`id`, `client_name`, `phone`, `message`, `product_id`, `create_time`, `update_time`, `delete_time`) VALUES
(1, '丽萨', '15153553030', '无', '2', NULL, NULL, NULL),
(2, '玉田', '15153553030', '无', '1', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- 表的结构 `tp_department`
--

CREATE TABLE `tp_department` (
  `id` int(11) NOT NULL,
  `department_name` varchar(100) NOT NULL,
  `department_des` varchar(255) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `tp_department`
--

INSERT INTO `tp_department` (`id`, `department_name`, `department_des`, `create_time`, `update_time`, `delete_time`) VALUES
(1, '销售部门', '', NULL, '2019-01-07 19:06:16', NULL),
(2, '售后部门', NULL, NULL, NULL, NULL),
(4, '阿三', '阿萨', '2019-01-07 19:05:30', '2019-01-07 19:05:30', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `tp_order`
--

CREATE TABLE `tp_order` (
  `id` int(11) NOT NULL,
  `client_id` varchar(20) NOT NULL,
  `product_id` varchar(20) NOT NULL,
  `pro_num` varchar(20) NOT NULL,
  `price` varchar(20) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `tp_order`
--

INSERT INTO `tp_order` (`id`, `client_id`, `product_id`, `pro_num`, `price`, `create_time`, `update_time`, `delete_time`) VALUES
(1, '1', '1', '1', '3200', '2019-01-06 21:00:29', '2019-01-06 21:00:29', NULL),
(2, '2', '2', '1', '4300', '2019-01-06 21:00:41', '2019-01-06 21:00:41', NULL),
(3, '3', '2', '1', '4300', '2019-01-06 21:00:52', '2019-01-06 21:00:52', NULL),
(4, '2', '2', '1', '4300', '2019-01-06 21:02:09', '2019-01-06 21:02:09', NULL),
(5, '1', '1', '2', '3200', '2019-01-06 21:02:24', '2019-01-06 21:02:24', NULL),
(6, '1', '1', '3', '3200', '2019-01-07 19:03:05', '2019-01-07 19:03:05', NULL),
(7, '1', '1', '1', '3200', '2019-01-07 19:03:53', '2019-01-07 19:03:53', NULL),
(8, '1', '2', '5', '4300', '2019-01-07 19:16:03', '2019-01-07 19:16:03', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `tp_product`
--

CREATE TABLE `tp_product` (
  `id` int(11) NOT NULL,
  `pro_name` varchar(255) NOT NULL,
  `pro_num` varchar(255) DEFAULT NULL,
  `pro_all_num` varchar(255) NOT NULL,
  `pro_price` varchar(40) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `tp_product`
--

INSERT INTO `tp_product` (`id`, `pro_name`, `pro_num`, `pro_all_num`, `pro_price`, `create_time`, `update_time`, `delete_time`) VALUES
(1, '电视', '113', '150', '3200', NULL, '2019-01-08 09:05:06', NULL),
(2, '冰箱', '0', '20', '430', NULL, '2019-01-07 19:39:39', NULL),
(3, '洗衣机', NULL, '120', '3600', '2019-01-07 19:14:10', '2019-01-07 19:14:10', NULL),
(4, '12', NULL, '1', '1231', '2019-01-07 19:22:49', '2019-01-07 19:22:49', NULL);

-- --------------------------------------------------------

--
-- 表的结构 `tp_user`
--

CREATE TABLE `tp_user` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(225) NOT NULL,
  `statue` enum('1','0') DEFAULT '1',
  `is_super` varchar(10) NOT NULL,
  `email` varchar(20) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `department_id` varchar(5) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `tp_user`
--

INSERT INTO `tp_user` (`id`, `username`, `password`, `statue`, `is_super`, `email`, `phone`, `department_id`, `create_time`, `update_time`, `delete_time`) VALUES
(1, '管理员', '123456', '1', '0', '1754102225@qq.com', '15153557272', '1', NULL, '2019-01-07 19:42:56', NULL),
(2, '丽萨', '123456', '1', '1', '1754102225@qq.com', '15153557272', '2', NULL, '2019-01-08 09:03:40', NULL),
(3, '李善', '123456', '1', '2', '1754103225@qq.com', '15153557472', '2', NULL, NULL, NULL),
(4, '刘元', '123456', '1', '3', '1754104225@qq.com', '15153557672', '1', NULL, NULL, NULL),
(5, '张氏', '123456', '1', '3', '1754102525@qq.com', '15153553272', '1', NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tp_client`
--
ALTER TABLE `tp_client`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tp_department`
--
ALTER TABLE `tp_department`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tp_order`
--
ALTER TABLE `tp_order`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tp_product`
--
ALTER TABLE `tp_product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tp_user`
--
ALTER TABLE `tp_user`
  ADD PRIMARY KEY (`id`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `tp_client`
--
ALTER TABLE `tp_client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- 使用表AUTO_INCREMENT `tp_department`
--
ALTER TABLE `tp_department`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- 使用表AUTO_INCREMENT `tp_order`
--
ALTER TABLE `tp_order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- 使用表AUTO_INCREMENT `tp_product`
--
ALTER TABLE `tp_product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- 使用表AUTO_INCREMENT `tp_user`
--
ALTER TABLE `tp_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
