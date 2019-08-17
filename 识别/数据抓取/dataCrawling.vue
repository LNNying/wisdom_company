<template>
    <!--数据抓取-->
    <div class="page-box">
        <Card class="customer-card">
            <Row class="mb-10">
                <i-col span="24">
                    <menu-content-layout-title style="float: left; padding-top: 4px;">数据抓取</menu-content-layout-title>
                    <Form :model="searchData" :label-width="0" inline style="width: 50%; float: left;">
                        <FormItem label="">
                            <Input size="small" v-model="searchData.loadNum" placeholder="提单号" @on-enter="loadData" type="text" :maxlength="64" clearable style="width: 150px;" />
                            <Select size="small" v-model="searchData.shipOwning" transfer placeholder="船公司" style="width:150px" clearable>
                                <Option v-for="(item,index) in shipOwning" :value="item.value" :key="index">{{ item.name }}</Option>
                            </Select>
                            <Button size="small" type="primary" icon="ios-search" @click="loadData">查询</Button>
                        </FormItem>
                    </Form>
                </i-col>
            </Row>
            <el-table
                    :data="mtxxList"
                    height="calc(100vh - 180px)"
                    border
                    style="width: 100%"
                    size="mini"
                    v-loading="loading"
                    @row-click="clickRow"
                    @select="selectRow">
                <el-table-column
                        type="selection"
                        width="36">
                </el-table-column>
                    <el-table-column
                            type="index"
                            label="#"
                            width="35"
                            align="center">
                    </el-table-column>
                <el-table-column
                        v-for="(item,index) in mtxxColumns"
                        :key="index"
                        :prop="item.key"
                        :label="item.title"
                        :width="item.width"
                        sortable="true">
                </el-table-column>
            </el-table>
        </Card>
    </div>
</template>

<script>
import api from '@/api/ocr/ocrOperation';
export default {
    name: 'dataCrawling',
    data() {
        return {
            loading: false,
            mtxxList: [],
            mtxxColumns: [
                {
                    title: '码头名称', // 码头名称
                    key: 'MTMC',
                    align: 'center',
                    width: 200
                },
                {
                    title: '提单号', // 提单号
                    key: 'TDH',
                    align: 'center',
                    width: 200
                },
                {
                    title: '中文船名', // 中文船名
                    key: 'CKZWCM',
                    align: 'center',
                    width: 200
                },
                {
                    title: '英文船名', // 英文船名
                    key: 'CKYWCM',
                    align: 'center',
                    width: 200
                },
                {
                    title: '航次', // 航次
                    key: 'CKHC',
                    align: 'center',
                    width: 200
                },
                {
                    title: '卸货港', // 卸货港
                    key: 'XHGYM',
                    align: 'center',
                    width: 200
                },
                {
                    title: '箱站代码', // 箱站代码
                    key: 'XZDM',
                    align: 'center',
                    width: 100
                },
                {
                    title: '箱号', // 箱号
                    key: 'XH',
                    align: 'center',
                    width: 150
                },
                {
                    title: '箱属', // 箱属
                    key: 'XSGSM',
                    align: 'center',
                    width: 100
                },
                {
                    title: '尺寸', // 尺寸
                    key: 'CC',
                    align: 'center',
                    width: 100
                },
                {
                    title: '箱型', // 箱型
                    key: 'XX',
                    align: 'center',
                    width: 100
                },
                {
                    title: '铅封号', // 铅封号
                    key: 'QFH1',
                    align: 'center',
                    width: 200
                },
                {
                    title: '整箱重', // 整箱重
                    key: 'MZ',
                    align: 'center',
                    width: 100
                },
                {
                    title: '空重', // 空重
                    key: 'KZ',
                    align: 'center',
                    width: 100
                },
                {
                    title: '码头放行', // 码头放行
                    key: 'FXBZ',
                    align: 'center',
                    width: 100
                },
                {
                    title: '当前状态', // 当前状态
                    key: 'DQZTMC',
                    align: 'center',
                    width: 100
                },
                {
                    title: '入港类别', // 入港类别
                    key: 'RGLB',
                    align: 'center',
                    width: 100
                },
                {
                    title: '入港时间', // 入港时间
                    key: 'SJRGSJ',
                    align: 'center',
                    width: 200
                },
                {
                    title: '出港类别', // 出港类别
                    key: 'CGLB',
                    align: 'center',
                    width: 100
                },
                {
                    title: '装船时间', // 装船时间
                    key: 'SJCGSJ',
                    align: 'center',
                    width: 200
                },
                {
                    title: '堆存天数', // 堆存天数
                    key: 'DCT',
                    align: 'center',
                    width: 100
                },
                {
                    title: '特殊装载需求', // 特殊装载需求
                    key: 'TSZZXQMC',
                    align: 'center',
                    width: 200
                },
                {
                    title: '内外贸', // 内外贸
                    key: 'NWM',
                    align: 'center',
                    width: 100
                },
                {
                    title: 'IMO号', // IMO号
                    key: 'IMO',
                    align: 'center',
                    width: 100
                }],
            searchData: {
                loadNum: '', // 提单号
                shipOwning: '' // 船公司
            },
            shipOwning: [
                {
                    value: 0,
                    name: '船一'
                },
                {
                    value: 1,
                    name: '船二'
                },
                {
                    value: 2,
                    name: '船三'
                }]
        }
    },
    methods: {
        loadData() {
            this.loading = true;
            let body = this.searchData.loadNum;
            if (body.trim().length !== 0) {
                api.ocrCrawling(body).then(({data}) => {
                    if (data.returnCode === 200) {
                        let list = data.returnData.mtxxList;
                        // console.log(data.returnData);
                        this.mtxxList = list;
                    }
                    this.loading = false;
                });
            } else {
                this.mtxxList = [];
                this.loading = false;
            }
        },
        selectRow(sel, row) {
            console.log(row);
        },
        clickRow(row) {
            console.log(row);
        }
    }
};
</script>

<style scoped>
    .page-box{
        padding: 10px;
        position: relative;
        box-sizing: border-box;
        overflow: hidden;
    }
</style>
