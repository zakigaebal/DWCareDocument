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

-- 테이블 데이터 dawoon.dc_caredocument:~2 rows (대략적) 내보내기
DELETE FROM `dc_caredocument`;
/*!40000 ALTER TABLE `dc_caredocument` DISABLE KEYS */;
INSERT INTO `dc_caredocument` (`careSeq`, `number`, `careStart`, `careFinish`, `time`, `sympton`, `count`, `injection`, `oral`, `age`, `birth`, `memo`, `flagYN`, `regDate`, `issueDate`, `issueID`) VALUES
	(0, 1, '2022-01-27', '2022-02-08', 2, '40', '11', '프로샷4.5케토프로4', '박원장', 78, '2022-01-27', 'ㄴ', 'Y', '2021-01-27 17:17:52', '2022-01-27 17:17:53', 'CDY'),
	(1, 2, '2022-01-27', '2022-02-08', 3, '39', '1', '주프레보4케토프로5', '박원장', 15, '2022-01-27', 'ㄴ', 'Y', '2022-01-27 17:19:00', '2022-01-27 17:19:01', 'CDY');
/*!40000 ALTER TABLE `dc_caredocument` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
