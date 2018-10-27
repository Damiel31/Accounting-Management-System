-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2016 at 11:53 AM
-- Server version: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `system`
--

-- --------------------------------------------------------

--
-- Table structure for table `act_1yr_1term`
--

CREATE TABLE IF NOT EXISTS `act_1yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `act_1yr_1term`
--

INSERT INTO `act_1yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ALGEBRA', 'Algebra', 3, 1695),
(2, 'COMART1', 'Communication Arts 1', 3, 1695),
(3, 'COMFUND', 'Computer Fundamentals', 3, 1695),
(4, 'COPRO-1 LECT', 'Computer Programming 1 Lecture', 3, 1695),
(5, 'COPRO-1 LAB', 'Computer Programming 1 Laboratory', 1, 1015),
(6, 'MATPLUS', 'Math Plus', 1, 565),
(7, 'NSTP001', 'National Service Training Program 1', 3, 1695),
(8, 'PHYEDU1', 'Physical Education 1', 2, 1130),
(9, 'PROFETH', 'Professional Ethics with Values Formation', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `act_1yr_2term`
--

CREATE TABLE IF NOT EXISTS `act_1yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `act_1yr_2term`
--

INSERT INTO `act_1yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART2', 'Communication Arts 2', 3, 1695),
(2, 'COPRO-2 LECT', 'Computer Programming 2 Lecture', 3, 1695),
(3, 'COPRO-2 LAB', 'Computer Programming 2 Laboratory', 1, 1015),
(4, 'DATSRUC LECT', 'Data Stuctures Lecture', 3, 1695),
(5, 'DATSRUC LAB', 'Data Stuctures Laboratory', 1, 1015),
(6, 'DISTRUC', 'Discrete Structures', 3, 1695),
(7, 'NSTP002', 'National Service Training Program 2', 3, 1695),
(8, 'NTROART', 'Introduction to Arts', 3, 1695),
(9, 'PHYEDU2', 'Physical Education 2', 2, 1130),
(10, 'TRIGONO', 'Trigonometry', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `act_2yr_1term`
--

CREATE TABLE IF NOT EXISTS `act_2yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `act_2yr_1term`
--

INSERT INTO `act_2yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART3', 'Communication Arts 3', 3, 1695),
(2, 'COPRO-3 LECT', 'Computer Programming 3 Lecture', 3, 1695),
(3, 'COPRO-3 LAB', 'Computer Programming 3 Laboratory', 1, 1015),
(4, 'LOGSIGN', 'Logic Design and Switching', 3, 1695),
(5, 'PHILGOV', 'Philippine History, Government and Constitution', 3, 1695),
(6, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(7, 'PHYSIC1 LECT', 'Physics 1 Lecture', 3, 1695),
(8, 'PHYSIC1 LAB', 'Physics 1 Laboratory', 1, 1015),
(9, 'PROSTAT', 'Probability and Statistics', 3, 1695),
(10, 'SOCULITA', 'Society, Culture and Information Technology with Family Planning', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `act_2yr_2term`
--

CREATE TABLE IF NOT EXISTS `act_2yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `act_2yr_2term`
--

INSERT INTO `act_2yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART4', 'Communication Arts 4', 3, 1695),
(2, 'CORLANG LECT', 'Computer Organization and Assembly Language Lecture', 3, 1695),
(3, 'CORLANG LAB', 'Computer Organization and Assembly Language Laboratory', 1, 1015),
(4, 'PHILMAN', 'Philosophy of Man', 3, 1695),
(5, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(6, 'PHYSIC2 LECT', 'Physics 2 Lecture', 3, 1695),
(7, 'PHYSIC2 LAB', 'Physics 2 Laboratory', 1, 1015),
(8, 'SADSIGN', 'Systems Analysis and Design', 3, 1695),
(9, 'THEODBS LECT', 'Theory of Database Systems', 3, 1695),
(10, 'THEODBS LAB', 'Theory of Database Systems Laboratory', 1, 1015);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_1yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsat_1yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_1yr_1term`
--

INSERT INTO `bsat_1yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COLALGE', 'College Algebra', 3, 1695),
(2, 'COMART1', 'Communication Arts 1', 3, 1695),
(3, 'COMFUND', 'Computer Fundamentals', 3, 1695),
(4, 'FUNACCT1', 'Fundamentals of Accounting 1', 6, 3390),
(5, 'MATPLUS', 'Math Plus', 1, 565),
(6, 'NSTP001', 'National Service Training Program 1', 3, 1695),
(7, 'PHYEDU1', 'Physical Education 1', 2, 1130),
(8, 'PRINMGT', 'Principle of Management', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_1yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsat_1yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_1yr_2term`
--

INSERT INTO `bsat_1yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART2', 'Communication Arts 2', 3, 1695),
(2, 'FILIP01', 'Komunikasyon Sa Akademikong Filipino', 3, 1695),
(3, 'FUNACCT2', 'Fundamentals of Acconting 2', 6, 3390),
(4, 'ITCASAD', 'IT Concepts and Systems Analysis and Design', 3, 1695),
(5, 'MATINVE', 'Mathematics of Investment', 3, 1695),
(6, 'NSTP002', 'National Service Training Program 2', 3, 1695),
(7, 'PHYEDU2', 'Physical Education 2', 2, 1130),
(8, 'PRIMARK', 'Principles and Methods of Marketing', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_2yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsat_2yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_2yr_1term`
--

INSERT INTO `bsat_2yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART3', 'Communication Arts 3', 3, 1695),
(2, 'FILIP02', 'Pagbasa at Pagsulat Tungo sa Pananaliksik', 3, 1695),
(3, 'FINAREP1', 'Financial Accounting and Reporting 1', 6, 3390),
(4, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(5, 'PHYSCIEB', 'Physical Science', 3, 1695),
(6, 'VALFORM', 'Values Formation', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_2yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsat_2yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(80) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_2yr_2term`
--

INSERT INTO `bsat_2yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ACCINSYS', 'Accounting Information Systems', 3, 1695),
(2, 'BASFIN', 'Basic Finance', 3, 1695),
(3, 'BIOSCIEA', 'Biological Science', 3, 1695),
(4, 'BUSISTA	', 'Business Statistics', 3, 1695),
(5, 'FINAREP2', 'Financial Accounting and Reporting 2', 6, 3390),
(6, 'MICROTAP', 'Microeconoimics Theory and Practice', 3, 1695),
(7, 'PDTAPPS', 'Fundamentals of Programming and Database Theory and Application', 3, 1695),
(8, 'PHYEDU4', 'Physical Education 4', 2, 1130);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_3yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsat_3yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_3yr_1term`
--

INSERT INTO `bsat_3yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ADVCACT', 'Advanced Computer Application For Accountants', 3, 1695),
(2, 'COSTACM', 'Cost Accounting And Cost Management', 6, 3390),
(3, 'FINAREP3', 'Financial Accounting And Reporting 3', 3, 1695),
(4, 'HUBEORG', 'Human Behavior In The Organizations', 3, 1695),
(5, 'INCTAX', 'Income Taxation', 3, 1695),
(6, 'MACROTAP', 'Macroeconomic Theory And Practice', 3, 1695),
(7, 'QTECBUS', 'Quantitative Techniques in Business', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_3yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsat_3yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_3yr_2term`
--

INSERT INTO `bsat_3yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ADFACAR', 'Advanced Financial Accounting And Reporting', 3, 1695),
(2, 'BUSSTAX', 'Business And Transfer Taxes', 3, 1695),
(3, 'GENPSYCA', 'Psychology With Drugs,HIV/AIDS,And SARS Education', 3, 1695),
(4, 'ITAUDIT', 'Internal Auditing in an IT Environment', 6, 3390),
(5, 'MNGTACT', 'Management Accounting', 3, 1695),
(6, 'OBLICON', 'Law on Obligations and Contracts', 3, 1695),
(7, 'PHILOCT', 'Introduction to Philosophy with Logic and Critical Thinking', 3, 1695),
(8, 'PROPMGT', 'Productions And Operations Management', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_3yr_summer`
--

CREATE TABLE IF NOT EXISTS `bsat_3yr_summer` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_3yr_summer`
--

INSERT INTO `bsat_3yr_summer` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ACCTPRA', 'Accounting Office Practicum', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_4yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsat_4yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(80) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_4yr_1term`
--

INSERT INTO `bsat_4yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ACTGNSP', 'Accounting for Government,Not-for-profit Entities and Specialized Industries', 3, 1695),
(2, 'ARTSSOC', 'Arts,Man,And Society', 3, 1695),
(3, 'FINCMGT', 'Financial Management', 3, 1695),
(4, 'JPRIZAL', 'life and Works of Rizal', 3, 1695),
(5, 'LAWBURSOR', 'Law of Business Organization', 3, 1695),
(6, 'PHILGOV', 'Philippine History,Government and Constitution', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsat_4yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsat_4yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(80) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsat_4yr_2term`
--

INSERT INTO `bsat_4yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'BUSTRAT', 'Business Policy and Strategy', 3, 1695),
(2, 'GOODGOV', 'Social Responsibility and Good Governance', 3, 1695),
(3, 'PHILIT', 'Philippine Literature', 3, 1695),
(4, 'SALCLAW', 'Sales,Agency,Labor and Other Commercial Laws', 3, 1695),
(5, 'SOCULITA', 'Society,Culture and Information Technology with Family Planning ', 3, 1695),
(6, 'TECHWRIT', 'Technical Writing', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_1yr_1term`
--

CREATE TABLE IF NOT EXISTS `bscs_1yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_1yr_1term`
--

INSERT INTO `bscs_1yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ALGEBRA', 'Alegebra', 3, 1695),
(2, 'COMART1', 'Communication Arts 1', 3, 1695),
(3, 'COMFUND', 'Computer Fundamentals', 3, 1695),
(4, 'COPRO-1 LAB', 'Computer Programming 1 Laboratory', 1, 1015),
(5, 'COPRO-1 LECT', 'Computer Programming 1 Lecture', 3, 1695),
(6, 'MATPLUS', 'Math Plus', 1, 565),
(7, 'NSTP001	', 'National Service Training Program 1', 3, 1695),
(8, 'PHYEDU1', 'Physical Education 1', 2, 1130),
(9, 'PROFETH', 'Professional Ethics with Values Formation', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_1yr_2term`
--

CREATE TABLE IF NOT EXISTS `bscs_1yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_1yr_2term`
--

INSERT INTO `bscs_1yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART2', 'Communication Arts 2', 3, 1695),
(2, 'COPRO-2 LAB', 'Computer Programming 2 Laboratory', 1, 1015),
(3, 'COPRO-2 LECT', 'Computer Programming 2 Lecture', 3, 1695),
(4, 'DATSRUC LAB', 'Data Stuctures Laboratory', 1, 1015),
(5, 'DATSRUC LECT', 'Data Stuctures Lecture', 3, 1695),
(6, 'DISTRUC', 'Discrete Structures', 3, 1695),
(7, 'NSTP002', 'National Service Training Program 2', 3, 1695),
(8, 'NTROART', 'Introduction to Arts', 3, 1695),
(9, 'PHYEDU2', 'Physical Education 2', 2, 1130),
(10, 'TRIGONO', 'Trigonometry', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_2yr_1term`
--

CREATE TABLE IF NOT EXISTS `bscs_2yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_2yr_1term`
--

INSERT INTO `bscs_2yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART3', 'Communication Arts 3', 3, 1695),
(2, 'COPRO-3 LAB', 'Computer Programming 3 Laboratory', 1, 1015),
(3, 'COPRO-3 LECT', 'Computer Programming 3 Lecture', 3, 1695),
(4, 'LOGSIGN', 'Logic Design and Switching', 3, 1695),
(5, 'PHILGOV', 'Philippine History, Government and Constitution', 3, 1695),
(6, 'PHYEDU3', 'Physical Education 3', 2, 1015),
(7, 'PHYSIC1 LAB', 'Physics 1 Laboratory', 1, 1015),
(8, 'PHYSIC1 LECT', 'Physics 1 Lecture', 3, 1695),
(9, 'PROSTAT', 'Probablity and Statistics', 3, 1695),
(10, 'SOCULITA', 'Society, Culture and Information Technology with Family Planning', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_2yr_2term`
--

CREATE TABLE IF NOT EXISTS `bscs_2yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_2yr_2term`
--

INSERT INTO `bscs_2yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART4', 'Communication Arts 4', 3, 1695),
(2, 'CORLANG LAB', 'Computer Oragnization and Assembly Language Laboratory', 1, 1015),
(3, 'CORLANG LECT', 'Computer Oragnization and Assembly Language Lecture', 3, 1695),
(4, 'PHILMAN', 'Philosophy of Man', 3, 1695),
(5, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(6, 'PHYSIC2 LAB', 'Physics 2 Laboratory', 1, 1015),
(7, 'PHYSIC2 LECT', 'Physics 2 Lecture', 3, 1695),
(8, 'SADSIGN', 'Systems Analysis and Design', 3, 1695),
(9, 'THEODBS LAB', 'Theory of Database Systems Laboratory', 1, 1015),
(10, 'THEODBS LECT', 'Theory of Database Systems Lecture', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_3yr_1term`
--

CREATE TABLE IF NOT EXISTS `bscs_3yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_3yr_1term`
--

INSERT INTO `bscs_3yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CSELE1', 'CS Free Elective 1', 3, 1695),
(3, 'CSELE2', 'CS Free Elective 2', 3, 1695),
(4, 'DESALGO', 'Design and Analysis of Algorithhms', 3, 1695),
(5, 'FILIP01', 'Komunikasyon Sa Akademikong Filipino', 3, 1695),
(6, 'OPERSYSB LAB', 'Operating Systems Laboratory', 1, 1015),
(7, 'OPERSYSB LECT', 'Operating Systems Lecture', 3, 1695),
(8, 'SOFTWEN LAB', 'Software Engineering Laboratory', 1, 1015),
(9, 'SOFTWEN LECT', 'Software Engineering Lecture', 3, 1695),
(10, 'THECOMP', 'Theory of Computation with Automata Theory', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_3yr_2term`
--

CREATE TABLE IF NOT EXISTS `bscs_3yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_3yr_2term`
--

INSERT INTO `bscs_3yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CALCLUS', 'Calculus', 3, 1695),
(2, 'COMNETS LAB', 'Computer Networks Laboratory', 1, 1015),
(3, 'COMNETS LECT', 'Computer Networks Lecture', 3, 1695),
(4, 'CSTHES0B', 'CS Thesis Proposal', 3, 1695),
(5, 'FILIP02', 'Pagbasa at Pagsulat Tungo sa Pananaliksik', 3, 1695),
(6, 'MODESIM', 'Modeling and Simulation', 3, 1695),
(7, 'WEBPROG', 'Web Programming', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_3yr_summer`
--

CREATE TABLE IF NOT EXISTS `bscs_3yr_summer` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(20) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_3yr_summer`
--

INSERT INTO `bscs_3yr_summer` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CS-PRAC', 'CS Practicum', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_4yr_1term`
--

CREATE TABLE IF NOT EXISTS `bscs_4yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_4yr_1term`
--

INSERT INTO `bscs_4yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CS-ELE1', 'CS Elective 1', 3, 1695),
(2, 'CSELE3', 'CS Free Elective 3', 3, 1695),
(3, 'CSTHES1B', 'CS Thesis 1', 3, 1695),
(4, 'GENPSYCA', 'Psycology with Drugs,HIV/AIDS and SARS Education', 3, 1695),
(5, 'PHILITA', 'Philippine Literature', 3, 1695),
(6, 'PROLANS', 'Programming Languages', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bscs_4yr_2term`
--

CREATE TABLE IF NOT EXISTS `bscs_4yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bscs_4yr_2term`
--

INSERT INTO `bscs_4yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CS-ELE2', 'CS Elective 2', 3, 1695),
(2, 'CSTHES2B', 'CS Thesis 2', 3, 1695),
(3, 'ECOTAX', 'Economics with Taxation and Agrarian Reform', 3, 1695),
(4, 'JPRIZAL', 'Life and Works of Rizal', 3, 1695),
(5, 'WORLLIT', 'World Literature', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_1yr_1term`
--

CREATE TABLE IF NOT EXISTS `bshrm_1yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_1yr_1term`
--

INSERT INTO `bshrm_1yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'BUSIMAT', 'Business Math', 3, 1695),
(2, 'COMART1', 'Communication Arts 1', 3, 1695),
(3, 'CULARTS', 'Basic Culinary Arts', 3, 1695),
(4, 'NSTP001', 'National Service Training Program 1', 3, 1695),
(5, 'PHYEDU1', 'Physical Education 1', 2, 1130),
(6, 'PRITUR1', 'Principles of Tourism 1', 3, 1695),
(7, 'SANIGEN', 'Principles of Food Safety,Hygiene and Sanitation', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_1yr_2term`
--

CREATE TABLE IF NOT EXISTS `bshrm_1yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_1yr_2term`
--

INSERT INTO `bshrm_1yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART2', 'Communitacion Arts 2', 3, 1695),
(2, 'COMFUND', 'Computer Fundamentals', 3, 1695),
(3, 'FILIP01', 'Komunikasyon sa Akademikong Filipino', 3, 1695),
(4, 'HRMELE1', 'HRM Elective 1', 3, 1695),
(5, 'LOGIC', 'Logic', 3, 1695),
(6, 'NSTP002', 'National Service Training Program 2', 3, 1695),
(7, 'PHYEDU2', 'Physical Education 2', 2, 1130),
(8, 'PRITUR2', 'Principles of Tourism 2', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table ` bshrm_2yr_1term`
--

CREATE TABLE IF NOT EXISTS ` bshrm_2yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table ` bshrm_2yr_1term`
--

INSERT INTO ` bshrm_2yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART3', 'Communication Arts 3', 3, 1695),
(2, 'FBSPROC', 'Food and Beverage Service Procedures', 3, 1695),
(3, 'FILIP02', 'Pagbasa at Pagsulat Tungo sa Pananaliksik', 3, 1695),
(4, 'GENPSYCA', 'Psycology with Drugs,HIV/AIDS and SARS Education', 3, 1695),
(5, 'HASTOPS', 'Housekeeping and Stewardship Operation', 3, 1695),
(6, 'HRMELE2', 'HRM Elective 2', 3, 1695),
(7, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(8, 'PRINMGT', 'Principle of Management', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_2yr_2term`
--

CREATE TABLE IF NOT EXISTS `bshrm_2yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_2yr_2term`
--

INSERT INTO `bshrm_2yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'BANCATE', 'Banquet,Function and Catering Procedure', 3, 1695),
(2, 'HRMELE3', 'HRM Elective 3', 3, 1695),
(3, 'HRMELE4', 'HRM Elective 4', 3, 1695),
(4, 'PHYEDU4', 'Physical Education 4', 2, 1130),
(5, 'PRINMKT', 'Principles of Marketing for the Service Industry', 3, 1695),
(6, 'PROTATA', 'Probability and Statistics', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_2yr_summer`
--

CREATE TABLE IF NOT EXISTS `bshrm_2yr_summer` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_2yr_summer`
--

INSERT INTO `bshrm_2yr_summer` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'HRMOJT1', 'BSHRM Practicum	1-300hrs. (Restaurant Operation Practicum)', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_3yr_1term`
--

CREATE TABLE IF NOT EXISTS `bshrm_3yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_3yr_1term`
--

INSERT INTO `bshrm_3yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'BACCTNG', 'Basic Accounting for the Service Industry', 3, 1695),
(2, 'BUSCOMM', 'Business Communication', 3, 1695),
(3, 'ECOTAX', 'Economics with Taxation and Agrarian Reform', 3, 1695),
(4, 'FRMTHRM', 'Front Office Management', 3, 1695),
(5, 'HRMBEORG', 'Human Behavior in the Oranization', 3, 1695),
(6, 'PHILGOV', 'Philippine History,Government and Constitution', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_3yr_2term`
--

CREATE TABLE IF NOT EXISTS `bshrm_3yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_3yr_2term`
--

INSERT INTO `bshrm_3yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'BASFINA', 'Basic Finance for the Service Industry', 3, 1695),
(2, 'ENTRPHRM', 'Entrepreneurship and Business Planning', 3, 1695),
(3, 'FOBECOM', 'Food and Beverage Control Management', 3, 1695),
(4, 'HRMELE5', 'HRM Elective 5', 3, 1695),
(5, 'HRMELE6', 'HRM Elective 6', 3, 1695),
(6, 'HRMENSCI', 'Environmental Science', 3, 1695),
(7, 'MISHOSPI', 'Management Information System in the Hospitality Industry', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_3yr_summer`
--

CREATE TABLE IF NOT EXISTS `bshrm_3yr_summer` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_3yr_summer`
--

INSERT INTO `bshrm_3yr_summer` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'HRMOJT2', 'BSHRM Practicum 2- 300hrs (Hotel Housekeeping Practicum)', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_4yr_1term`
--

CREATE TABLE IF NOT EXISTS `bshrm_4yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_4yr_1term`
--

INSERT INTO `bshrm_4yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'CULTANT', 'Cultural Anthropology', 3, 1695),
(2, 'HRMELE7', 'HRM Elective 7', 3, 1695),
(3, 'HRMELE8', 'HRM Elective 8', 3, 1695),
(4, 'HRMEVMT', 'Event Management', 4, 2260),
(5, 'HUMANT', 'Humanities', 3, 1695),
(6, 'JRIZALA', 'Life and Works of Rizal', 3, 1695),
(7, 'QUALMGT', 'Total Quality Management', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bshrm_4yr_2term`
--

CREATE TABLE IF NOT EXISTS `bshrm_4yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bshrm_4yr_2term`
--

INSERT INTO `bshrm_4yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'HRMOJT3', 'BSHRM Practicum 3- 400 hrs (Hotel Front Office/Operations Practicum)', 4, 2260);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_1yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsit_1yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_1yr_1term`
--

INSERT INTO `bsit_1yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ALGEBRA', 'Alegebra', 3, 1695),
(2, 'COMART1', 'Communication Arts 1', 3, 1695),
(3, 'COMFUND', 'Computer Fundamentals', 3, 1695),
(4, 'COPRO-1 LAB', 'Computer Programming 1 Laboratory', 1, 1015),
(5, 'COPRO-1 LECT', 'Computer Programming 1 Lecture', 3, 1695),
(6, 'MATPLUS', 'Math Plus', 1, 565),
(7, 'NSTP001', 'National Service Training Program 1', 3, 1695),
(8, 'PHYEDU1', 'Physical Education 1', 2, 1130),
(9, 'PROFETH', 'Professional Ethics with Values Formation', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_1yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsit_1yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_1yr_2term`
--

INSERT INTO `bsit_1yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART2', 'Communication Arts 2', 3, 1695),
(2, 'COPRO-2 LAB', 'Computer Programming 2 Laboratory', 1, 1015),
(3, 'COPRO-2 LECT', 'Computer Programming 2 Lecture', 3, 1695),
(4, 'DATSRUC LAB', 'Data Stuctures Laboratory', 1, 1015),
(5, 'DATSRUC LECT', 'Data Stuctures Lecture', 3, 1695),
(6, 'DISTRUC', 'Discrete Structures', 3, 1695),
(7, 'NSTP002', 'National Service Training Program 2', 3, 1695),
(8, 'NTROART', 'Introduction to Arts', 3, 1695),
(9, 'PHYEDU2', 'Physical Education 2', 2, 1130),
(10, 'TRIGONO', 'Trigonometry', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_2yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsit_2yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(70) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_2yr_1term`
--

INSERT INTO `bsit_2yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART3', 'Communication Arts 3', 3, 1695),
(2, 'COPRO-3 LECT', 'Computer Programming 3 Lecture', 3, 1695),
(3, 'COPRO-3 LAB', 'Computer Programming 3 Laboratory', 1, 1015),
(4, 'LOGSIGN', 'Logic Design and Switching', 3, 1695),
(5, 'PHILGOV', 'Philippine History, Government and Constitution', 3, 1695),
(6, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(7, 'PHYSIC1 LECT', 'Physics 1 Lecture', 3, 1695),
(8, 'PHYSIC1 LAB', 'Physics 1 Laboratory', 1, 1015),
(9, 'PROSTAT', 'Probablity and Statistics', 3, 1695),
(10, 'SOCULITA', 'Society, Culture and Information Technology with Family Planning', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_2yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsit_2yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_2yr_2term`
--

INSERT INTO `bsit_2yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMART4', 'Communication Arts 4', 3, 1695),
(2, 'CORLANG LECT', 'Computer Oragnization and Assembly Language Lecture', 3, 1695),
(3, 'CORLANG LAB', 'Computer Oragnization and Assembly Language Laboratory', 1, 1015),
(4, 'PHILMAN', 'Philosophy of Man', 3, 1695),
(5, 'PHYEDU3', 'Physical Education 3', 2, 1130),
(6, 'PHYSIC2 LECT', 'Physics 2 Lecture', 3, 1695),
(7, 'PHYSIC2 LAB', 'Physics 2 Laboratory', 1, 1015),
(8, 'SADSIGN', 'Systems Analysis and Design', 3, 1695),
(9, 'THEODBS LECT', 'Theory of Database Systems Lecture', 3, 1695),
(10, 'THEODBS LAB', 'Theory of Database Systems Laboratory', 1, 1015);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_3yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsit_3yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_3yr_1term`
--

INSERT INTO `bsit_3yr_1term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'ACCPRIN', 'Accounting Principles', 3, 1695),
(2, 'ADDBASE', 'Advance Database Systems', 3, 1695),
(3, 'FILIP01', 'Komunikasyon sa Akademikong Filipino', 3, 1695),
(4, 'ITELE1', 'IT Free Elective 1', 3, 1695),
(5, 'OPERSYS', 'Operating Systems', 3, 1695),
(6, 'WEBPROG LECT', 'Web Programming Lecture', 3, 1695),
(7, 'WEBPROG LAB', 'Web Programming Laboratory', 1, 1015);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_3yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsit_3yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_3yr_2term`
--

INSERT INTO `bsit_3yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'COMNETS LECT', 'Computer Networks Lecture', 3, 1695),
(2, 'COMNETS LAB', 'Computer Networks Laboratory', 1, 1015),
(3, 'ECOTAX', 'Economics with Taxation and Agrarian Reform', 3, 1695),
(4, 'FILIP02', 'Pagbasa at Pagsulat Tungo sa Pananaliksik', 3, 1695),
(5, 'ITELE1', 'IT Elective 1', 3, 1695),
(6, 'ITELE2', 'IT Free Elective 2', 3, 1695),
(7, 'MULSYS LECT', 'Multimedia Systems Lecture', 3, 1695),
(8, 'MULSYS LAB', 'Multimedia Systems Laboratory', 1, 1015);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_4yr_1term`
--

CREATE TABLE IF NOT EXISTS `bsit_4yr_1term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Descrition` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_4yr_1term`
--

INSERT INTO `bsit_4yr_1term` (`ID`, `Course_Code`, `Descrition`, `Unit`, `Amount`) VALUES
(1, 'GENPSYCA', 'Psycology with Drugs,HIV/AIDS and SARS Education', 3, 1695),
(2, 'ITELE2', 'IT Elective 2', 3, 1695),
(3, 'ITELE3', 'IT Free Elective 3', 3, 1695),
(4, 'ITSPROJ', 'IT Special Project (Thesis)', 3, 1695),
(5, 'PHILLITA', 'Philippines Literature', 3, 1695),
(6, 'TECHNOP', 'Technopreneurship', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `bsit_4yr_2term`
--

CREATE TABLE IF NOT EXISTS `bsit_4yr_2term` (
  `ID` int(20) NOT NULL,
  `Course_Code` varchar(20) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Unit` int(20) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bsit_4yr_2term`
--

INSERT INTO `bsit_4yr_2term` (`ID`, `Course_Code`, `Description`, `Unit`, `Amount`) VALUES
(1, 'IT-PRACB', 'IT Practicum', 6, 3390),
(2, 'JPRIZAL', 'Life and Works of Rizal', 3, 1695),
(3, 'WORLLIT', 'WOrld Literature', 3, 1695);

-- --------------------------------------------------------

--
-- Table structure for table `logon`
--

CREATE TABLE IF NOT EXISTS `logon` (
  `ID` int(20) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logon`
--

INSERT INTO `logon` (`ID`, `Username`, `Password`) VALUES
(1, 'Damiel', 'Admin'),
(2, 'Gino', 'Admin'),
(3, 'Bryan', 'Admin'),
(4, 'Mates', 'Admin'),
(5, 'Dondoy', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `miscellaneoues`
--

CREATE TABLE IF NOT EXISTS `miscellaneoues` (
  `ID` int(20) NOT NULL,
  `Miscellaneous_Fee` varchar(40) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `miscellaneoues`
--

INSERT INTO `miscellaneoues` (`ID`, `Miscellaneous_Fee`, `Amount`) VALUES
(1, 'Students Activities Fee', 150),
(2, 'Internet Fee', 450),
(3, 'Network Events Fee', 50),
(4, 'Supreme Student Council Fee', 50),
(5, 'Student Leaerning Materials Fee', 200),
(6, 'NYC Fee', 525),
(7, 'Athletics Fee', 300),
(8, 'Learning Management System', 250),
(9, 'PRISSA Fee', 100),
(10, 'Physics 2 Manual', 108);

-- --------------------------------------------------------

--
-- Table structure for table `other_school_fees`
--

CREATE TABLE IF NOT EXISTS `other_school_fees` (
  `ID` int(30) NOT NULL,
  `Fee` varchar(50) NOT NULL,
  `Amount` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_school_fees`
--

INSERT INTO `other_school_fees` (`ID`, `Fee`, `Amount`) VALUES
(1, 'Instructional Materials and Equipment', 1520),
(2, 'Insurance Fee', 100),
(3, 'Journal and Publication', 140),
(4, 'Library', 990),
(5, 'Registration Fee', 500),
(6, 'Software Licensing Fee', 500),
(7, 'Student Development Fee', 200),
(8, 'Student Services Fee', 950);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `Stud_ID` varchar(30) NOT NULL,
  `Last_Name` varchar(30) NOT NULL,
  `First_Name` varchar(30) NOT NULL,
  `Middle_Name` varchar(30) NOT NULL,
  `Gender` varchar(30) NOT NULL,
  `BirthDate` varchar(30) NOT NULL,
  `Program` varchar(30) NOT NULL,
  `Mobile_No` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Address` varchar(30) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `Religion` varchar(30) NOT NULL,
  `Year` varchar(30) NOT NULL,
  `Semester` varchar(30) NOT NULL,
  `Schedule` varchar(30) NOT NULL,
  `Tuition_Fees` varchar(30) NOT NULL,
  `Advance_Payment` varchar(30) NOT NULL,
  `Total_Assessment` varchar(30) NOT NULL,
  `Yr` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`Stud_ID`, `Last_Name`, `First_Name`, `Middle_Name`, `Gender`, `BirthDate`, `Program`, `Mobile_No`, `Email`, `Address`, `Status`, `Religion`, `Year`, `Semester`, `Schedule`, `Tuition_Fees`, `Advance_Payment`, `Total_Assessment`, `Yr`) VALUES
('STI-916-3-22-2016', 'Maquiling', 'Damiel', 'Fernandez', 'Male', '06/19/1998', 'BSCS', '09159726723', 'damiellight@gmail.com', 'Landmark', 'Single', 'Catholic', '1st', 'First Semester', 'Morning Class', '12880', '2500', '15280', ''),
('STI-98-3-22-2016', 'asdasd', 'asd', 'asd', 'Female', '06/19/1998', 'BSCS', 'asd', 'asd', 'asd', 'asd', 'asd', '1st', 'First Semester', 'Morning Class', '14910', '1000', '18810', '1998');

-- --------------------------------------------------------

--
-- Table structure for table `student_paymentsched`
--

CREATE TABLE IF NOT EXISTS `student_paymentsched` (
  `Stud_ID` varchar(30) NOT NULL,
  `Payments` varchar(600) NOT NULL,
  `Amount` varchar(600) NOT NULL,
  `non` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_paymentsched`
--

INSERT INTO `student_paymentsched` (`Stud_ID`, `Payments`, `Amount`, `non`) VALUES
('STI-285-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '5013\r\n3870\r\n3870\r\n3870\r\n3870', '0'),
('STI-484-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '2875\r\n3870\r\n3870\r\n3870\r\n3870', '0'),
('STI-868-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '1983\r\n3870\r\n3870\r\n3870\r\n3870', '0'),
('STI-916-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '1983\r\n3870\r\n3870\r\n3870\r\n3870', '0'),
('STI-96-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '4163\r\n3870\r\n3870\r\n3870\r\n3870', '0'),
('STI-98-3-22-2016', 'DOWNPAYMENT\r\n2ND PAYMENT\r\n3RD PAYMENT\r\n4TH PAYMENT\r\n5TH PAYMENT', '5513\r\n3870\r\n3870\r\n3870\r\n3870', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `act_1yr_1term`
--
ALTER TABLE `act_1yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `act_1yr_2term`
--
ALTER TABLE `act_1yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `act_2yr_1term`
--
ALTER TABLE `act_2yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `act_2yr_2term`
--
ALTER TABLE `act_2yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_1yr_1term`
--
ALTER TABLE `bsat_1yr_1term`
  ADD PRIMARY KEY (`Course_Code`);

--
-- Indexes for table `bsat_1yr_2term`
--
ALTER TABLE `bsat_1yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_2yr_1term`
--
ALTER TABLE `bsat_2yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_2yr_2term`
--
ALTER TABLE `bsat_2yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_3yr_1term`
--
ALTER TABLE `bsat_3yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_3yr_2term`
--
ALTER TABLE `bsat_3yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_3yr_summer`
--
ALTER TABLE `bsat_3yr_summer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsat_4yr_1term`
--
ALTER TABLE `bsat_4yr_1term`
  ADD PRIMARY KEY (`Course_Code`);

--
-- Indexes for table `bsat_4yr_2term`
--
ALTER TABLE `bsat_4yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_1yr_1term`
--
ALTER TABLE `bscs_1yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_1yr_2term`
--
ALTER TABLE `bscs_1yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_2yr_1term`
--
ALTER TABLE `bscs_2yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_2yr_2term`
--
ALTER TABLE `bscs_2yr_2term`
  ADD PRIMARY KEY (`Course_Code`);

--
-- Indexes for table `bscs_3yr_1term`
--
ALTER TABLE `bscs_3yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_3yr_2term`
--
ALTER TABLE `bscs_3yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_3yr_summer`
--
ALTER TABLE `bscs_3yr_summer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_4yr_1term`
--
ALTER TABLE `bscs_4yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bscs_4yr_2term`
--
ALTER TABLE `bscs_4yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_1yr_1term`
--
ALTER TABLE `bshrm_1yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_1yr_2term`
--
ALTER TABLE `bshrm_1yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table ` bshrm_2yr_1term`
--
ALTER TABLE ` bshrm_2yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_2yr_2term`
--
ALTER TABLE `bshrm_2yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_2yr_summer`
--
ALTER TABLE `bshrm_2yr_summer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_3yr_1term`
--
ALTER TABLE `bshrm_3yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_3yr_2term`
--
ALTER TABLE `bshrm_3yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_3yr_summer`
--
ALTER TABLE `bshrm_3yr_summer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_4yr_1term`
--
ALTER TABLE `bshrm_4yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bshrm_4yr_2term`
--
ALTER TABLE `bshrm_4yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_1yr_1term`
--
ALTER TABLE `bsit_1yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_1yr_2term`
--
ALTER TABLE `bsit_1yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_2yr_1term`
--
ALTER TABLE `bsit_2yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_2yr_2term`
--
ALTER TABLE `bsit_2yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_3yr_1term`
--
ALTER TABLE `bsit_3yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_3yr_2term`
--
ALTER TABLE `bsit_3yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_4yr_1term`
--
ALTER TABLE `bsit_4yr_1term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit_4yr_2term`
--
ALTER TABLE `bsit_4yr_2term`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `logon`
--
ALTER TABLE `logon`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `miscellaneoues`
--
ALTER TABLE `miscellaneoues`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `other_school_fees`
--
ALTER TABLE `other_school_fees`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Stud_ID`), ADD UNIQUE KEY `Stud_ID` (`Stud_ID`);

--
-- Indexes for table `student_paymentsched`
--
ALTER TABLE `student_paymentsched`
  ADD PRIMARY KEY (`Stud_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
