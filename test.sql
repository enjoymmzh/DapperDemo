/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 50717
 Source Host           : localhost:3306
 Source Schema         : test

 Target Server Type    : MySQL
 Target Server Version : 50717
 File Encoding         : 65001

 Date: 05/07/2021 15:41:01
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for aaa
-- ----------------------------
DROP TABLE IF EXISTS `aaa`;
CREATE TABLE `aaa`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 28 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of aaa
-- ----------------------------
INSERT INTO `aaa` VALUES (1, '张三');
INSERT INTO `aaa` VALUES (2, '李四');
INSERT INTO `aaa` VALUES (3, '六二');
INSERT INTO `aaa` VALUES (4, '213123');
INSERT INTO `aaa` VALUES (5, '123');
INSERT INTO `aaa` VALUES (6, 'asfads');
INSERT INTO `aaa` VALUES (7, '张三1');
INSERT INTO `aaa` VALUES (8, '李四2');
INSERT INTO `aaa` VALUES (9, '六二3');
INSERT INTO `aaa` VALUES (10, '修改掉1');
INSERT INTO `aaa` VALUES (11, '修改掉');
INSERT INTO `aaa` VALUES (12, '算法');
INSERT INTO `aaa` VALUES (21, '123123');
INSERT INTO `aaa` VALUES (22, 'afasdf');
INSERT INTO `aaa` VALUES (23, 'afasdf');
INSERT INTO `aaa` VALUES (24, 'afasdf');
INSERT INTO `aaa` VALUES (25, 'afasdf');
INSERT INTO `aaa` VALUES (26, 'afasdf');
INSERT INTO `aaa` VALUES (27, 'afasdf');

-- ----------------------------
-- Table structure for demo
-- ----------------------------
DROP TABLE IF EXISTS `demo`;
CREATE TABLE `demo`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `test_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `test_age` int(10) NULL DEFAULT NULL,
  `create_date` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0),
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `age` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `date` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `test_name`(`test_name`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 22 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of demo
-- ----------------------------
INSERT INTO `demo` VALUES (1, '张三', 2, '2020-09-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (2, '李四', 143, '2020-10-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (3, '六二', 23, '2020-11-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (4, '213123', 123123, '2020-12-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (5, '123', 343, '2021-01-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (6, 'asfads', 234, '2021-02-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (7, '张三1', 2, '2021-03-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (8, '李四2', 143, '2021-04-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (9, '六二3', 23, '2021-05-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (10, '修改掉1', 666, '2021-06-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (11, '修改掉', 343, '2021-07-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (12, '算法', 234, '2021-08-06 10:04:43', NULL, NULL, NULL);
INSERT INTO `demo` VALUES (21, '李坤强', NULL, NULL, NULL, NULL, NULL);

-- ----------------------------
-- Table structure for demo_copy1
-- ----------------------------
DROP TABLE IF EXISTS `demo_copy1`;
CREATE TABLE `demo_copy1`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `age` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `date` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 22 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of demo_copy1
-- ----------------------------
INSERT INTO `demo_copy1` VALUES (1, '张三', '2', '2020-09-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (2, '李四', '143', '2020-10-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (3, '六二', '23', '2020-11-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (4, '213123', '123123', '2020-12-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (5, '123', '343', '2021-01-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (6, 'asfads', '234', '2021-02-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (7, '张三1', '2', '2021-03-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (8, '李四2', '143', '2021-04-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (9, '六二3', '23', '2021-05-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (10, '修改掉1', '666', '2021-06-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (11, '修改掉', '343', '2021-07-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (12, '算法', '234', '2021-08-06 10:04:43');
INSERT INTO `demo_copy1` VALUES (21, '123123', '3434', NULL);

-- ----------------------------
-- Table structure for person
-- ----------------------------
DROP TABLE IF EXISTS `person`;
CREATE TABLE `person`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `LastName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `DateCreated` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 25 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of person
-- ----------------------------
INSERT INTO `person` VALUES (1, '张三', NULL, NULL);
INSERT INTO `person` VALUES (2, '李四', NULL, NULL);
INSERT INTO `person` VALUES (3, '六二', NULL, NULL);
INSERT INTO `person` VALUES (4, '213123', NULL, NULL);
INSERT INTO `person` VALUES (5, '123', NULL, NULL);
INSERT INTO `person` VALUES (6, 'asfads', NULL, NULL);
INSERT INTO `person` VALUES (7, '张三1', NULL, NULL);
INSERT INTO `person` VALUES (8, '李四2', NULL, NULL);
INSERT INTO `person` VALUES (9, '六二3', NULL, NULL);
INSERT INTO `person` VALUES (10, '修改掉1', NULL, NULL);
INSERT INTO `person` VALUES (11, '修改掉', NULL, NULL);
INSERT INTO `person` VALUES (12, '算法', NULL, NULL);
INSERT INTO `person` VALUES (21, '123123', NULL, NULL);
INSERT INTO `person` VALUES (22, 'Foo', 'Bar', '0001-01-01 00:00:00');
INSERT INTO `person` VALUES (23, 'Foo', 'Bar', '0001-01-01 00:00:00');
INSERT INTO `person` VALUES (24, 'Foo', 'Bar', '0001-01-01 00:00:00');

-- ----------------------------
-- Table structure for potousers
-- ----------------------------
DROP TABLE IF EXISTS `potousers`;
CREATE TABLE `potousers`  (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `FirstName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `LastName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `MiddleName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `EmailID` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Adddate` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`UserID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of potousers
-- ----------------------------
INSERT INTO `potousers` VALUES (1, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:32:03');
INSERT INTO `potousers` VALUES (2, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:38:34');
INSERT INTO `potousers` VALUES (3, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:38:34');
INSERT INTO `potousers` VALUES (4, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:42:23');
INSERT INTO `potousers` VALUES (5, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:46:03');
INSERT INTO `potousers` VALUES (6, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 14:51:29');
INSERT INTO `potousers` VALUES (7, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 15:06:43');
INSERT INTO `potousers` VALUES (8, 'geovindu', 'Foo', 'Bar', '', 'geovindu@163.com', '2021-07-05 15:06:52');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user_pwd` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `create_date` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES (1, 'admin', '123456', '2021-07-05 15:40:52');

SET FOREIGN_KEY_CHECKS = 1;
