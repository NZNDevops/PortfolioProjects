-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 11, 2021 at 07:41 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sibaoverflow`
--

-- --------------------------------------------------------

--
-- Table structure for table `post`
--

CREATE TABLE `post` (
  `post_id` int(11) NOT NULL,
  `user_id` varchar(15) DEFAULT NULL,
  `title` varchar(100) NOT NULL,
  `question` text NOT NULL,
  `description` text DEFAULT NULL,
  `likes` int(11) DEFAULT 0,
  `comments` int(11) DEFAULT 0,
  `post_date` date DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `post`
--

INSERT INTO `post` (`post_id`, `user_id`, `title`, `question`, `description`, `likes`, `comments`, `post_date`) VALUES
(7, '023-18-0011', 'Node Js', 'How to use Router in node js', 'hello world hello world hello world hello world hello world hello world hello world hello world hello world hello world hello ', 0, 4, '2021-07-03'),
(11, '023-18-0011', 'React', 'How to use React props ?', 'Here is my code..........\r\nHere is my code..........\r\nHere is my code..........', 0, 5, '2021-07-03'),
(13, '023-19-889', 'cpp', 'how to use struct in cpp code?', 'here is the code.', 0, 1, '2021-07-04'),
(14, '023-18-0012', 'express.js', 'how to use http module with express.js ?', 'here is the description of my code...', 0, 1, '2021-07-04'),
(15, '023-18-0011', 'python', 'how to use lambdha in pyhton ??', 'hello world', 0, 1, '2021-07-04'),
(16, '023-18-0011', 'probability', 'how to solve the given problem?', 'I actually wouldn’t recoI actually wouldn’t recommend using generators over more traditional state management strategiesmmend using generators over more traditional state management strategies', 0, 1, '2021-07-04'),
(17, '023-18-0011', 'probability', 'hoe to solve given question?', 'bionomial destribution', 0, 1, '2021-07-04'),
(18, '023-18-0011', 'cpp', 'ejfnjfnjnj', 'kmmmmmmmmmmmmmmmmmmmmm', 0, 1, '2021-07-04'),
(19, '023-18-0015', 'AI', 'what is AI?', 'airt n nnnnnnnnbbbbbbbb', 0, 2, '2021-07-06'),
(20, '023-18-0023', 'Maths', 'How to solve Quardratic Equation using matlib ?', 'here is my questionn...', 0, 0, '2021-07-11');

-- --------------------------------------------------------

--
-- Table structure for table `postcomments`
--

CREATE TABLE `postcomments` (
  `post_id` int(11) NOT NULL,
  `user_id` varchar(11) NOT NULL,
  `comment_date` date DEFAULT NULL,
  `comment_text` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `postcomments`
--

INSERT INTO `postcomments` (`post_id`, `user_id`, `comment_date`, `comment_text`) VALUES
(11, '023-18-0012', '2021-02-11', 'You can find your solution at .....'),
(11, '023-18-0015', '2021-07-09', 'Please add some more description about your question..'),
(11, '023-19-889', '2021-07-09', 'here is the soulution please go and check question..'),
(0, '', NULL, ''),
(7, '023-18-0011', '2020-07-11', 'please follow given link to see how to use react routers'),
(7, '023-18-0015', '2020-07-11', 'please follow given link to see how to use react routers'),
(14, '023-18-0011', '2021-06-11', 'please follow given link to how to use http module'),
(7, '023-18-0011', '2021-06-11', 'please provide some more detail about your quesrtion'),
(19, '023-18-0011', '2021-06-11', 'I do not understand what you want to ask'),
(7, '023-18-0023', '2021-06-11', 'you can install react router using npm command later you can follow given link for usage'),
(13, '023-18-0023', '2021-06-11', 'you can use it in same way as you use classes in cpp'),
(11, '023-18-0023', '2021-06-11', 'react props are used to transfer data from parent to child'),
(19, '023-18-0023', '2021-06-11', 'Airtificial intelligence is same as human intelligence'),
(15, '023-18-0023', '2021-06-11', 'to use lamdha in python you can use arrow syntax'),
(16, '023-18-0023', '2021-06-11', 'you can use binomial theroum for this problem'),
(17, '023-18-0023', '2021-06-11', 'you need to use gamma distribution here'),
(18, '023-18-0023', '2021-06-11', 'please provide some valid description for your question');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `cms_id` varchar(15) NOT NULL,
  `first_name` varchar(30) NOT NULL,
  `last_name` varchar(30) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  `gender` varchar(7) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `role` varchar(10) DEFAULT NULL,
  `department` varchar(8) DEFAULT NULL,
  `semester` int(2) DEFAULT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`cms_id`, `first_name`, `last_name`, `password`, `gender`, `birth_date`, `role`, `department`, `semester`, `description`) VALUES
('023-18-0000', 'hina', 'nadeem', '852852', 'female', '2006-12-18', NULL, NULL, NULL, NULL),
('023-18-0011', 'Nageeta', 'Wadhwani', '0011', 'Female', '1997-03-27', 'Student', 'CS', 6, 'Hello this is nageeta from Bs-Cs semeter 6.\r\nI am here to help you out with logics and programms'),
('023-18-0012', 'bin noor', 'usama', '123123123', 'male', '1998-07-16', NULL, NULL, NULL, NULL),
('023-18-0015', 'shehla', 'mushtaq', '789789789', 'female', '1998-11-18', NULL, NULL, NULL, NULL),
('023-18-0023', 'muskan', 'batra', '12345', 'female', '1997-09-14', NULL, NULL, NULL, 'this is muskan batra'),
('023-19-889', 'ramo', 'gopi', '123456789', 'female', '2009-11-17', NULL, NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `post`
--
ALTER TABLE `post`
  ADD PRIMARY KEY (`post_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`cms_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `post`
--
ALTER TABLE `post`
  MODIFY `post_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `post`
--
ALTER TABLE `post`
  ADD CONSTRAINT `post_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`cms_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
