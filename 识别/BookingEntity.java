package com.wisdom.ocr.pdf.entity;

import java.util.List;

import lombok.AllArgsConstructor;
import lombok.Data;

/**
 * Created by victor on 2018-11-07. (ง •̀_•́)ง
 */

@Data
public class BookingEntity {
    /**
     * 订舱号
     */
    private String bookingNumber;

    /**
     * 收货地
     */
    private String receiptPlace;

    /**
     * 装货港
     */
    private String loadingPort;

    /**
     * 中转港
     */
    private List<String> transshipmentPorts;

    /**
     * 卸货港
     */
    private String dischargePort;

    /**
     * 交货地
     */
    private String deliveryPlace;

    /**
     * 目的地
     */
    private String destinationPlace;

    /**
     * 品名
     */
    private String commodity;

    /**
     * 船名, 航次
     */
    private List<VesselVoyage> vesselVoyages;

    /**
     * 箱型, 箱量
     */
    private List<ContainerTypeNumber> containerTypeNumbers;

    /**
     * 件
     */
    private List<String> packages;

    /**
     * 重
     */
    private List<String> grossWeight;


    /**
     * 尺
     */
    private List<String> measurement;

    /**
     * 放箱时间
     */
    private String containerReleaseTime;

    /**
     * 场站(提箱地点)
     */
    private String yard;

    /**
     * 付款方式
     */
    private String payMethod;

    /**
     * 约号
     */
    private String agreementNumber;

    /**
     * 运输条款
     */
    private String carriageCondition;

    /**
     * Special Handling
     */
    private String specialHandling;

    /**
     * ON BEHALF OF
     */
    private String onBehalfOf;

    @Data
    @AllArgsConstructor(staticName = "of")
    public static class VesselVoyage {
        private String vessel;
        private String voyage;

        @Override
        public String toString() {
            return "(vessel=" + vessel + ", voyage=" + voyage + ")";
        }
    }

    @Data
    @AllArgsConstructor(staticName = "of")
    public static class ContainerTypeNumber {
        private String cntType;
        private String cntNumber;
        private String cntRemark;

        @Override
        public String toString() {
            return "(type=" + cntType + ", number=" + cntNumber + ", remark=" + cntRemark + ")";
        }
    }
}
