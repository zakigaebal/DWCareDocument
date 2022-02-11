-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        10.1.28-MariaDB - mariadb.org binary distribution
-- 서버 OS:                        Win32
-- HeidiSQL 버전:                  11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- 테이블 dawoon.dc_caredocument 구조 내보내기
DROP TABLE IF EXISTS `dc_caredocument`;
CREATE TABLE IF NOT EXISTS `dc_caredocument` (
  `careSeq` int(11) NOT NULL COMMENT '고유번호',
  `number` int(11) DEFAULT NULL COMMENT '개체번호',
  `careStart` date DEFAULT NULL COMMENT '치료시작일',
  `careFinish` date DEFAULT NULL COMMENT '치료종료일',
  `time` int(11) DEFAULT NULL COMMENT '시간',
  `sympton` varchar(50) DEFAULT NULL COMMENT '증상',
  `count` varchar(50) DEFAULT '' COMMENT '회수',
  `injection` varchar(50) DEFAULT '' COMMENT '주사처방',
  `oral` varchar(50) DEFAULT '' COMMENT '경구투여',
  `age` int(11) DEFAULT NULL COMMENT '일령',
  `birth` date DEFAULT NULL COMMENT '생년월일',
  `memo` varchar(50) DEFAULT NULL COMMENT '메모',
  `flagYN` varchar(1) DEFAULT 'Y' COMMENT '가용여부(Y:유효/N:삭제)',
  `regDate` datetime DEFAULT NULL COMMENT '최초저장일',
  `issueDate` datetime DEFAULT NULL COMMENT '최종저장일',
  `issueID` varchar(20) DEFAULT '' COMMENT '최종저장자 ID'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='질병치료대장';

-- 테이블 데이터 dawoon.dc_caredocument:~1 rows (대략적) 내보내기
DELETE FROM `dc_caredocument`;
/*!40000 ALTER TABLE `dc_caredocument` DISABLE KEYS */;
INSERT INTO `dc_caredocument` (`careSeq`, `number`, `careStart`, `careFinish`, `time`, `sympton`, `count`, `injection`, `oral`, `age`, `birth`, `memo`, `flagYN`, `regDate`, `issueDate`, `issueID`) VALUES
	(0, 1, '2021-07-02', '2022-02-08', 2, '40', '11', '프로샷4.5케토프로4', '박원장', 78, '2021-06-02', 'ㄴ', 'Y', '2021-01-27 17:17:52', '2022-01-27 17:17:53', 'CDY');
/*!40000 ALTER TABLE `dc_caredocument` ENABLE KEYS */;

-- 테이블 dawoon.dc_careenroll 구조 내보내기
DROP TABLE IF EXISTS `dc_careenroll`;
CREATE TABLE IF NOT EXISTS `dc_careenroll` (
  `careSeq` int(10) unsigned NOT NULL COMMENT '시퀀스 ',
  `number` int(11) DEFAULT NULL COMMENT '개체 시퀀스',
  `birth` datetime DEFAULT NULL COMMENT '생일',
  `flagYN` varchar(20) DEFAULT 'Y',
  `regDate` datetime DEFAULT NULL,
  `issueDate` datetime DEFAULT NULL,
  `issueID` varchar(20) DEFAULT '',
  PRIMARY KEY (`careSeq`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='1일 총섭취량기록부';

-- 테이블 데이터 dawoon.dc_careenroll:~1 rows (대략적) 내보내기
DELETE FROM `dc_careenroll`;
/*!40000 ALTER TABLE `dc_careenroll` DISABLE KEYS */;
INSERT INTO `dc_careenroll` (`careSeq`, `number`, `birth`, `flagYN`, `regDate`, `issueDate`, `issueID`) VALUES
	(1, 2, '2022-12-12 22:22:22', 'Y', '2022-02-11 17:38:11', '2022-02-11 17:38:12', 'CHY');
/*!40000 ALTER TABLE `dc_careenroll` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
